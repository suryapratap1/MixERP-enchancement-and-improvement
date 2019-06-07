using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateUnitField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlSelect unitSelect = new HtmlSelect())
                {
                    unitSelect.ID = "UnitSelect";
                    unitSelect.Attributes.Add("title", "Ctrl + U");
                    cell.Controls.Add(unitSelect);
                }

                row.Cells.Add(cell);
            }
        }
    }
}