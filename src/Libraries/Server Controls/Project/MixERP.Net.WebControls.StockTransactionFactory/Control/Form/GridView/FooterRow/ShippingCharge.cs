using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void CreateShippingChargeField(TableRow row)
        {
            using (TableCell cell = new TableCell())
            {
                using (HtmlInputText shippingChargeInputText = new HtmlInputText())
                {
                    shippingChargeInputText.ID = "ShippingChargeInputText";
                    shippingChargeInputText.Attributes.Add("title", "Ctrl + D");
                    shippingChargeInputText.Attributes.Add("class", "currency text-right");

                    if (!this.ShowShippingInformation)
                    {
                        shippingChargeInputText.Attributes.Add("readonly", "readonly");
                    }


                    cell.Controls.Add(shippingChargeInputText);
                }

                row.Cells.Add(cell);
            }
        }
    }
}