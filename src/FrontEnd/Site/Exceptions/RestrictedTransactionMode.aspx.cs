using MixERP.Net.Common.Helpers;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using System;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.FrontEnd.Site.Exceptions
{
    public partial class RestrictedTransactionMode : MixERPWebpage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.IsLandingPage = true;

            using (HtmlGenericControl header = new HtmlGenericControl("h1"))
            {
                header.InnerText = Titles.RestrictedTransactionMode;
                this.Placeholder1.Controls.Add(header);
            }

            using (HtmlGenericControl divider = HtmlControlHelper.GetDivider())
            {
                this.Placeholder1.Controls.Add(divider);
            }

            using (HtmlGenericControl p = new HtmlGenericControl("p"))
            {
                p.InnerText = Warnings.RestrictedTransactionMode;
                this.Placeholder1.Controls.Add(p);
            }

            using (HtmlAnchor anchor = new HtmlAnchor())
            {
                anchor.InnerText = Titles.BackToPreviousPage;
                anchor.HRef = "javascript:history.go(-1);";
                anchor.Attributes.Add("class", "ui pink button");
                this.Placeholder1.Controls.Add(anchor);
            }
        }
    }
}