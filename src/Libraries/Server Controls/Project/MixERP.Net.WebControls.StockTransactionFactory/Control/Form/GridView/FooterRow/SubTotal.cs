using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateSubTotalField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText subTotalInputText = new HtmlInputText())
                {
                    subTotalInputText.ID = "SubTotalInputText";
                    subTotalInputText.Attributes.Add("class", "currency text-right");
                    subTotalInputText.Attributes.Add("readonly", "readonly");

                    cell.Controls.Add(subTotalInputText);
                }

                row.Cells.Add(cell);
            }
        }
    }
}