using MixERP.Net.Common.Helpers;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using System;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.FrontEnd.Site
{
    public partial class AccessIsDenied : MixERPWebpage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            using (HtmlGenericControl header = new HtmlGenericControl("h1"))
            {
                header.InnerText = Warnings.AccessIsDenied;
                this.Placeholder1.Controls.Add(header);
            }

            using (HtmlGenericControl divider = HtmlControlHelper.GetDivider())
            {
                this.Placeholder1.Controls.Add(divider);
            }

            using (HtmlGenericControl p = new HtmlGenericControl("p"))
            {
                p.InnerText = Warnings.NotAuthorized;
                this.Placeholder1.Controls.Add(p);
            }
        }
    }
}