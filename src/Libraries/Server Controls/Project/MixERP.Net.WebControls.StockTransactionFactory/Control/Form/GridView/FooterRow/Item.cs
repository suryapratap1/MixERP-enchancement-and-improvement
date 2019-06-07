using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateItemCodeField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText itemCodeInputText = new HtmlInputText())
                {
                    itemCodeInputText.ID = "ItemCodeInputText";
                    itemCodeInputText.Attributes.Add("title", "ALT + C");

                    cell.Controls.Add(itemCodeInputText);
                }

                row.Cells.Add(cell);
            }
        }

        private static void CreateItemField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlSelect itemSelect = new HtmlSelect())
                {
                    itemSelect.ID = "ItemSelect";
                    itemSelect.Attributes.Add("title", "Ctrl + I");
                    cell.Controls.Add(itemSelect);
                }

                row.Cells.Add(cell);
            }
        }

    }
}