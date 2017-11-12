using AWS_WebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWS_WebApp.Account
{
    public partial class InstanceActions : System.Web.UI.Page
    {
        protected void Page_Load()
        {
            if (!IsPostBack)
            {
                var id = Request.QueryString["Id"];
                var action = Request.QueryString["Action"];
                if (id == null || action == null)
                {
                    lblSuccessMessage.Visible = true;
                    lblSuccessMessage.Text = "Click here to go to the account details page";
                    btnOkay.Visible = true;
                }
                else
                {
                    var provider = new AWSManagementServiceProvider();
                    switch (action.ToLower())
                    {
                        case "terminate":
                            provider.TerminateInstance(id);
                            ShowSuccessMessage(action);
                            break;
                        case "start":
                            provider.StartInstance(id);
                            ShowSuccessMessage(action);
                            break;
                        case "stop":
                            provider.StopInstance(id);
                            ShowSuccessMessage(action);
                            break;
                        case "launchinstance":
                            ShowSuccessMessage("launch");
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void ShowSuccessMessage(string action)
        {
            lblSuccessMessage.Visible = true;
            lblSuccessMessage.Text = "Instance " + action + "ed" + " successfully";
            btnOkay.Visible = true;
        }


        protected void btnOkay_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Account/AccountDetails.aspx");
        }
    }
}