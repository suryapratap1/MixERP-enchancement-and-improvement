using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void CreateFooterRow(Table grid)
        {
            using (TableRow row = new TableRow())
            {
                row.TableSection = TableRowSection.TableBody;
                row.CssClass = "ui footer-row form";

                CreateItemCodeField(row);
                CreateItemField(row);
                CreateQuantityField(row);
                CreateUnitField(row);
                CreatePriceField(row);
                CreateAmountField(row);
                CreateDiscountField(row);
                this.CreateShippingChargeField(row);
                CreateSubTotalField(row);
                CreateTaxFormField(row);
                CreateTaxtField(row);
                CreateActionField(row);

                grid.Rows.Add(row);
            }
        }
    }
}