using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void AddShippingAddressCompositeField(HtmlGenericControl container)
        {
            using (HtmlGenericControl shippingAddressInfoDiv = HtmlControlHelper.GetField())
            {
                shippingAddressInfoDiv.ID = "ShippingAddressInfoDiv";
                shippingAddressInfoDiv.Attributes.Add("style", "width:500px;");

                using (HtmlGenericControl fields = HtmlControlHelper.GetFields("two fields"))
                {
                    AddShippingCompanyField(fields);
                    AddShippingAddressField(fields);

                    shippingAddressInfoDiv.Controls.Add(fields);
                }


                container.Controls.Add(shippingAddressInfoDiv);
            }
        }

        private static void AddShippingAddressField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.ShippingAddress, "ShippingAddressSelect"))
                {
                    field.Controls.Add(label);
                }
                using (HtmlSelect shippingAddressSelect = new HtmlSelect())
                {
                    shippingAddressSelect.ID = "ShippingAddressSelect";
                    field.Controls.Add(shippingAddressSelect);
                }

                container.Controls.Add(field);
            }
        }

        private static void AddShippingCompanyField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.ShippingCompany, "ShippingCompanySelect"))
                {
                    field.Controls.Add(label);
                }
                using (HtmlSelect shippingCompanySelect = new HtmlSelect())
                {
                    shippingCompanySelect.ID = "ShippingCompanySelect";
                    field.Controls.Add(shippingCompanySelect);
                }

                container.Controls.Add(field);
            }
        }
    }
}