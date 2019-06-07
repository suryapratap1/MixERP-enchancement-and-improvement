using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.StockTransactionFactory.Helpers;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateHeaderRow(Table grid)
        {
            using (TableRow header = new TableRow())
            {
                header.TableSection = TableRowSection.TableHeader;

                TableHelper.CreateHeaderCell(header, Titles.ItemCode, "ItemCodeInputText");
                TableHelper.CreateHeaderCell(header, Titles.ItemName, "ItemSelect");
                TableHelper.CreateHeaderCell(header, Titles.QuantityAbbreviated, "QuantityInputText");
                TableHelper.CreateHeaderCell(header, Titles.Unit, "UnitSelect");
                TableHelper.CreateHeaderCell(header, Titles.Price, "PriceInputText");
                TableHelper.CreateHeaderCell(header, Titles.Amount, "AmountInputText");
                TableHelper.CreateHeaderCell(header, Titles.Discount, "DiscountInputText");
                TableHelper.CreateHeaderCell(header, Titles.ShippingCharge, "ShippingChargeInputText");
                TableHelper.CreateHeaderCell(header, Titles.SubTotal, "SubTotalInputText");
                TableHelper.CreateHeaderCell(header, Titles.TaxForm, "TaxSelect");
                TableHelper.CreateHeaderCell(header, Titles.Tax, "TaxInputText");
                TableHelper.CreateHeaderCell(header, Titles.Action, null);

                grid.Rows.Add(header);
            }
        }
    }
}