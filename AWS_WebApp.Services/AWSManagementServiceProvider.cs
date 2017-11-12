using AWSManagementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_WebApp.Services
{
    public class AWSManagementServiceProvider
    {
        public List<UIServiceDetails> GetServiceDetails()
        {
            var client = new ServiceClient();
            var response = client.GetServiceDetails();
            return TranslateToUIResponse(response);
        }

        private List<UIServiceDetails> TranslateToUIResponse(List<ServiceDetails> response)
        {
            var uiResponse = new List<UIServiceDetails>();
            if(response != null && response.Count > 0)
            {
                foreach (var details in response)
                {
                    var res = new UIServiceDetails();
                    res.InstanceName = details.InstanceName;
                    res.InstanceType = details.InstanceType;
                    res.Status = details.Status;
                    res.Action = GetAction(details.Status);
                    res.InstanceId = details.InstanceId;
                    uiResponse.Add(res);
                }
            }
            return uiResponse;
        }

        private string GetAction(string status)
        {
            var actions = new List<Action>();
            switch (status)
            {
                case "running": return "stop";
                case "stopped": return "start";
                case "stopping": return "";
                case "terminated":
                    break;
                default:
                    break;
            }
            return "stop";
        }

        public bool TerminateInstance(string instanceId)
        {
            var client = new ServiceClient();
            var response = client.TerminateInstance(instanceId);
            return response;
        }

        public bool StartInstance(string instanceId)
        {
            var client = new ServiceClient();
            var response = client.StartInstance(instanceId);
            return response;
        }

        public bool StopInstance(string instanceId)
        {
            var client = new ServiceClient();
            var response = client.StopInstance(instanceId);
            return response;
        }

        public bool LaunchEC2Instance(string amid, string groupname, string keyname, string instanceType)
        {
            var client = new ServiceClient();
            var request = new Ec2InstanceRequest() {
                AmiId = amid,
                Groups = new List<string>() { groupname},
                KeyPairName = keyname,
                InstanceType = instanceType
            };
            var response = client.LaunchEc2Instance(request);
            return (response.Count > 0);
        }
    }
}
