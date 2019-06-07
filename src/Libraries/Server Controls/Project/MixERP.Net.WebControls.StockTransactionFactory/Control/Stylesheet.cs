using System;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

[assembly: WebResource("MixERP.Net.WebControls.StockTransactionFactory.Includes.Style.StockTransactionFactory.css", "text/css", PerformSubstitution = true)]

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private const string resource = "MixERP.Net.WebControls.StockTransactionFactory.Includes.Style.StockTransactionFactory.css";

        [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
        private void AddStylesheet()
        {
            string href = this.Page.Request.Url.GetLeftPart(UriPartial.Authority) + this.Page.ClientScript.GetWebResourceUrl(typeof(StockTransactionForm), resource);

            using (HtmlLink link = new HtmlLink())
            {
                link.Attributes.Add("rel", "stylesheet");
                link.Attributes.Add("type", "text/css");
                link.Href = href;

                this.Page.Header.Controls.Add(link);
            }
        }
    }
}