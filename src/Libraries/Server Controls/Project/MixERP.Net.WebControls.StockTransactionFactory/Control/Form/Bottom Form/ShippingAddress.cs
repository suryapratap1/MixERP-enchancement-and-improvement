using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void AddShippingAddressTextAreaField(HtmlGenericControl container)
        {
            using (HtmlGenericControl shippingAddressDiv = HtmlControlHelper.GetField())
            {
                shippingAddressDiv.ID = "ShippingAddressDiv";

                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.ShippingAddress, "ShippingAddressTextArea"))
                {
                    shippingAddressDiv.Controls.Add(label);
                }

                using (HtmlTextArea shippingAddressTextArea = new HtmlTextArea())
                {
                    shippingAddressTextArea.ID = "ShippingAddressTextArea";
                    shippingAddressTextArea.Attributes.Add("readonly", "readonly");

                    shippingAddressDiv.Controls.Add(shippingAddressTextArea);
                }

                container.Controls.Add(shippingAddressDiv);
            }
        }
    }
}