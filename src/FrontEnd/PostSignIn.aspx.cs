using System;
using MixERP.Net.FrontEnd.Application;

namespace MixERP.Net.FrontEnd
{
    public partial class PostSignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Context.Session["FirstStepsPending"] = FirstSteps.CheckIfPending();

            this.Context.Response.Redirect(this.GetReturnUrl());
        }

        private string GetReturnUrl()
        {
            string returnUrl = this.Context.Request.QueryString["ReturnUrl"];

            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return "~";
            }

            return returnUrl;
        }
    }
}