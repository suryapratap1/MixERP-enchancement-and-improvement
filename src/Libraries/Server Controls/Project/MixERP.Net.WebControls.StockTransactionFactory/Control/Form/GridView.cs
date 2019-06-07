using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MixERP.Net.Common.Helpers;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void CreateGrid(Control container)
        {
            using (HtmlGenericControl div = new HtmlGenericControl("div"))
            {
                div.Attributes.Add("style", "width:100%;overflow:auto;");
                div.Attributes.Add("class", "ui form vpad16");

                using (Table productGridView = new Table())
                {
                    productGridView.ID = "ProductGridView";
                    productGridView.CssClass = "ui table";
                    productGridView.Style.Value = ConfigurationHelper.GetStockTransactionFactoryParameter("GridStyle");

                    CreateHeaderRow(productGridView);
                    this.CreateFooterRow(productGridView);

                    div.Controls.Add(productGridView);
                }

                container.Controls.Add(div);
            }
        }
    }
}