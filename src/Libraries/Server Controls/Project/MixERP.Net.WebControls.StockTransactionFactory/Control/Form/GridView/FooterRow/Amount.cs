using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateAmountField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText amountInputText = new HtmlInputText())
                {
                    amountInputText.ID = "AmountInputText";
                    amountInputText.Attributes.Add("class", "currency text-right");
                    amountInputText.Attributes.Add("readonly", "readonly");

                    cell.Controls.Add(amountInputText);
                }

                row.Cells.Add(cell);
            }
        }
    }
}