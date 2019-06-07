using System.Web.UI.HtmlControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void AddPriceTypeSelectField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.PriceType))
                {
                    field.Controls.Add(label);
                }

                using (HtmlSelect priceTypeSelect = new HtmlSelect())
                {
                    priceTypeSelect.ID = "PriceTypeSelect";
                    field.Controls.Add(priceTypeSelect);
                }

                container.Controls.Add(field);
            }
        }
    }
}