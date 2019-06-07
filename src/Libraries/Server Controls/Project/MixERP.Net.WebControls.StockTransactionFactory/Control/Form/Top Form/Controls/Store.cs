using System.Web.UI.HtmlControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void AddStoreSelectField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.SelectStore))
                {
                    field.Controls.Add(label);
                }


                using (HtmlSelect storeSelect = new HtmlSelect())
                {
                    storeSelect.ID = "StoreSelect";
                    field.Controls.Add(storeSelect);
                }

                container.Controls.Add(field);
            }
        }
    }
}