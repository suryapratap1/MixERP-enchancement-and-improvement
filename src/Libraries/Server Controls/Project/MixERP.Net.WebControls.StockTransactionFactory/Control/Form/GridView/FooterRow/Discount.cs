using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateDiscountField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText discountInputText = new HtmlInputText())
                {
                    discountInputText.ID = "DiscountInputText";
                    discountInputText.Attributes.Add("title", "Ctrl + D");
                    discountInputText.Attributes.Add("class", "currency text-right");

                    cell.Controls.Add(discountInputText);
                }

                row.Cells.Add(cell);
            }
        }
    }
}