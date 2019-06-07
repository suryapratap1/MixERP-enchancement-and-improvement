using MixERP.Net.FrontEnd.Base;
using System;
using System.Web.UI.WebControls;

namespace MixERP.Net.FrontEnd.Site.Account
{
    public partial class UserProfile : MixERPWebpage
    {
        public LinkButton emailLinkButton;

        protected void Page_Init(object sender, EventArgs e)
        {
            this.IsLandingPage = true;
        }

        //private void EmailReportLinkButton_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}