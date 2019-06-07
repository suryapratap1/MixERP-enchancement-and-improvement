using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n;
using System;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.FrontEnd
{
    public partial class MixERPReportMaster : MixERPMasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            using (HtmlLink stylesheet = new HtmlLink())
            {
                string path = "/bundles/report.css";

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
    }
}