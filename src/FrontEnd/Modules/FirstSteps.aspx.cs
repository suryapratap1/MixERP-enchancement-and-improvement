using System;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.FrontEnd.Modules
{
    public partial class FirstSteps : MixERPWebpage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.IsLandingPage = true;
        }
    }
}