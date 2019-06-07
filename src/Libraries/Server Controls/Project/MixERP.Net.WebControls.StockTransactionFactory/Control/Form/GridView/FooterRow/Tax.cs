using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateTaxFormField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlSelect taxSelect = new HtmlSelect())
                {
                    taxSelect.ID = "TaxSelect";
                    taxSelect.Attributes.Add("title", "Ctrl + T");
                    cell.Controls.Add(taxSelect);
                }

                row.Cells.Add(cell);
            }
        }

        private static void CreateTaxtField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText taxInputText = new HtmlInputText())
                {
                    taxInputText.ID = "TaxInputText";
                    taxInputText.Attributes.Add("class", "currency text-right");
                    taxInputText.Attributes.Add("readonly", "readonly");

                    cell.Controls.Add(taxInputText);
                }

                row.Cells.Add(cell);
            }
        }
    }
}