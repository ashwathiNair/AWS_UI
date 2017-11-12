using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_WebApp.Services
{
    public class UIServiceDetails
    {
        public string InstanceType { get; set;}
        public string InstanceName { get; set; }
        public string Status { get; set; }
        public string Action { get; set; }
        public string InstanceId { get; set; }
    }

    public class Action
    {
        public string ActionName { get; set; }

        public string Id { get; set; }
    }
}
