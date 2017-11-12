using AWS_WebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWS_WebApp.Account
{
    public partial class LaunchInstance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLaunch_Click(object sender, EventArgs e)
        {
            var provider = new AWSManagementServiceProvider();
            var response = provider.LaunchEC2Instance(txtAMID.Text, txtGroupName.Text, txtKeyPairName.Text, txtInstanceType.Text);
            if (response)
            {
                Response.Redirect("/Account/InstanceActions?Id=1&Action=launchInstance");
            }
            else
            {
                lblFailureMessage.Visible = true;
            }
        }
    }
}