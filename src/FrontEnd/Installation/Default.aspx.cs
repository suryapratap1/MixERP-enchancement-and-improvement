using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.FrontEnd.Data.Office;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.FrontEnd.Installation
{
    public partial class Default : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            using (HtmlLink stylesheet = new HtmlLink())
            {
                string path = "/bundles/master-page.css";

                if (CultureManager.IsRtl())
                {
                    path = path.Replace("css", "rtl.css");
                }

                stylesheet.Href = path;
                stylesheet.Attributes["rel"] = "stylesheet";
                stylesheet.Attributes["type"] = "text/css";
                stylesheet.Attributes["media"] = "all";
                this.Page.Header.Controls.Add(stylesheet);
            }

            if (Offices.GetOffices(AppUsers.GetCurrentUserDB()).Any())
            {
                this.Response.Redirect("~/SignIn.aspx");
            }

            this.RegisterJavascript();
        }

        private void RegisterJavascript()
        {
            string script = JSUtility.GetVar("allFieldsRequiredLocalized", Labels.AllFieldsRequired);
            script += JSUtility.GetVar("confirmedPasswordDoesNotMatch", Labels.ConfirmedPasswordDoesNotMatch);

            PageUtility.RegisterJavascript("InstallPage_Vars", script, this.Page, true);
        }
    }
}