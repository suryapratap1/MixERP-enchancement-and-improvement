using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreatePriceField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText priceInputText = new HtmlInputText())
                {
                    priceInputText.ID = "PriceInputText";
                    priceInputText.Attributes.Add("title", "Alt + P");
                    priceInputText.Attributes.Add("class", "currency text-right");

                    cell.Controls.Add(priceInputText);
                }

                row.Cells.Add(cell);
            }
        }
    }
}