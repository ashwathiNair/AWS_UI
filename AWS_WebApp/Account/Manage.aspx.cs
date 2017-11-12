using AWS_WebApp.Services;

namespace AWS_WebApp.Account
{
    public partial class Manage : System.Web.UI.Page
    {
       

        protected void Page_Load()
        {
            var id = Request.QueryString["Id"];
            var action = Request.QueryString["Action"];
            switch (action)
            {
                case "Terminate": TerminateInstance(id);
                    break;

                default:
                    break;
            }
        }

        private void TerminateInstance(string id)
        {
            var provider = new AWSManagementServiceProvider();
            var response = provider.TerminateInstance(id);
        }
    }
}