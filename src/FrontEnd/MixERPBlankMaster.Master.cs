using MixERP.Net.FrontEnd.Base;
using System;
using System.Web.UI.HtmlControls;
using MixERP.Net.i18n;

namespace MixERP.Net.FrontEnd
{
    public partial class MixERPBlankMaster : MixERPMasterPage
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
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}