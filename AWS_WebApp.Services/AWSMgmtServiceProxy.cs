﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AWSManagementService
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ServiceDetails", Namespace = "http://schemas.datacontract.org/2004/07/AWSMgmtService")]
    public partial class ServiceDetails : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ActionField;

        private string InstanceIdField;

        private string InstanceNameField;

        private string InstanceTypeField;

        private string StatusField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Action
        {
            get
            {
                return this.ActionField;
            }
            set
            {
                this.ActionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceId
        {
            get
            {
                return this.InstanceIdField;
            }
            set
            {
                this.InstanceIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceName
        {
            get
            {
                return this.InstanceNameField;
            }
            set
            {
                this.InstanceNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceType
        {
            get
            {
                return this.InstanceTypeField;
            }
            set
            {
                this.InstanceTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Ec2InstanceRequest", Namespace = "http://schemas.datacontract.org/2004/07/AWSMgmtService")]
    public partial class Ec2InstanceRequest : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string AmiIdField;

        private System.Collections.Generic.List<string> GroupsField;

        private string InstanceTypeField;

        private string KeyPairNameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AmiId
        {
            get
            {
                return this.AmiIdField;
            }
            set
            {
                this.AmiIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<string> Groups
        {
            get
            {
                return this.GroupsField;
            }
            set
            {
                this.GroupsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstanceType
        {
            get
            {
                return this.InstanceTypeField;
            }
            set
            {
                this.InstanceTypeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KeyPairName
        {
            get
            {
                return this.KeyPairNameField;
            }
            set
            {
                this.KeyPairNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "AWSManagementService.IService")]
    public interface IService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/GetServiceDetails", ReplyAction = "http://tempuri.org/IService/GetServiceDetailsResponse")]
        System.Collections.Generic.List<AWSManagementService.ServiceDetails> GetServiceDetails();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/GetServiceDetails", ReplyAction = "http://tempuri.org/IService/GetServiceDetailsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AWSManagementService.ServiceDetails>> GetServiceDetailsAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/TerminateInstance", ReplyAction = "http://tempuri.org/IService/TerminateInstanceResponse")]
        bool TerminateInstance(string instanceId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/TerminateInstance", ReplyAction = "http://tempuri.org/IService/TerminateInstanceResponse")]
        System.Threading.Tasks.Task<bool> TerminateInstanceAsync(string instanceId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/StartInstance", ReplyAction = "http://tempuri.org/IService/StartInstanceResponse")]
        bool StartInstance(string instanceId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/StartInstance", ReplyAction = "http://tempuri.org/IService/StartInstanceResponse")]
        System.Threading.Tasks.Task<bool> StartInstanceAsync(string instanceId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/StopInstance", ReplyAction = "http://tempuri.org/IService/StopInstanceResponse")]
        bool StopInstance(string instanceId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/StopInstance", ReplyAction = "http://tempuri.org/IService/StopInstanceResponse")]
        System.Threading.Tasks.Task<bool> StopInstanceAsync(string instanceId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/LaunchEc2Instance", ReplyAction = "http://tempuri.org/IService/LaunchEc2InstanceResponse")]
        System.Collections.Generic.List<string> LaunchEc2Instance(AWSManagementService.Ec2InstanceRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService/LaunchEc2Instance", ReplyAction = "http://tempuri.org/IService/LaunchEc2InstanceResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> LaunchEc2InstanceAsync(AWSManagementService.Ec2InstanceRequest request);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : AWSManagementService.IService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<AWSManagementService.IService>, AWSManagementService.IService
    {

        public ServiceClient()
        {
        }

        public ServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public ServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public System.Collections.Generic.List<AWSManagementService.ServiceDetails> GetServiceDetails()
        {
            return base.Channel.GetServiceDetails();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<AWSManagementService.ServiceDetails>> GetServiceDetailsAsync()
        {
            return base.Channel.GetServiceDetailsAsync();
        }

        public bool TerminateInstance(string instanceId)
        {
            return base.Channel.TerminateInstance(instanceId);
        }

        public System.Threading.Tasks.Task<bool> TerminateInstanceAsync(string instanceId)
        {
            return base.Channel.TerminateInstanceAsync(instanceId);
        }

        public bool StartInstance(string instanceId)
        {
            return base.Channel.StartInstance(instanceId);
        }

        public System.Threading.Tasks.Task<bool> StartInstanceAsync(string instanceId)
        {
            return base.Channel.StartInstanceAsync(instanceId);
        }

        public bool StopInstance(string instanceId)
        {
            return base.Channel.StopInstance(instanceId);
        }

        public System.Threading.Tasks.Task<bool> StopInstanceAsync(string instanceId)
        {
            return base.Channel.StopInstanceAsync(instanceId);
        }

        public System.Collections.Generic.List<string> LaunchEc2Instance(AWSManagementService.Ec2InstanceRequest request)
        {
            return base.Channel.LaunchEc2Instance(request);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> LaunchEc2InstanceAsync(AWSManagementService.Ec2InstanceRequest request)
        {
            return base.Channel.LaunchEc2InstanceAsync(request);
        }
    }
}
