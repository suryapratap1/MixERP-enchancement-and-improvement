using System.Web.UI.HtmlControls;
using MixERP.Net.Common.Helpers;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddPaymentTermSelectField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel("&nbsp;"))
                {
                    field.Controls.Add(label);
                }

                using (HtmlSelect paymentTermSelect = new HtmlSelect())
                {
                    paymentTermSelect.ID = "PaymentTermSelect";
                    field.Controls.Add(paymentTermSelect);
                }

                container.Controls.Add(field);
            }
        }
    }
}