using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateActionField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputButton addButton = new HtmlInputButton())
                {
                    addButton.ID = "AddButton";
                    addButton.Attributes.Add("class", "small ui button blue");
                    addButton.Value = Titles.Add;
                    addButton.Attributes.Add("title", "Ctrl + Return");

                    cell.Controls.Add(addButton);
                }
                row.Cells.Add(cell);
            }
        }
    }
}