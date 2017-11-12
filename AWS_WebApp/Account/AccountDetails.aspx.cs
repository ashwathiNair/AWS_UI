using AWS_WebApp.Services;
using AWSManagementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWS_WebApp.Account
{
    public partial class AccountDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //make retrieve details call and then render
            var awsProvider = new AWSManagementServiceProvider();
            var serviceDetails = awsProvider.GetServiceDetails();
            this.BindGrid(serviceDetails);
            string qryStr = Request.QueryString["UserName"];
            if (string.IsNullOrEmpty(qryStr) == false)
            {
                LblOne.Text = qryStr;
            }
        }


        private void BindGrid(List<UIServiceDetails> svcDetails)
        {
            gvServiceDetails.DataSource = svcDetails;
            gvServiceDetails.DataBind();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Account/LaunchInstance.aspx");
        }
    }
}