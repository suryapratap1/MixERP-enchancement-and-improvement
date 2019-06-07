using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateQuantityField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText quantityInputText = new HtmlInputText())
                {
                    quantityInputText.ID = "QuantityInputText";
                    quantityInputText.Attributes.Add("title", "Ctrl + Q");
                    quantityInputText.Attributes.Add("class", "integer text-right");

                    quantityInputText.Value = "1";

                    cell.Controls.Add(quantityInputText);
                }

                row.Cells.Add(cell);
            }
        }
    }
}