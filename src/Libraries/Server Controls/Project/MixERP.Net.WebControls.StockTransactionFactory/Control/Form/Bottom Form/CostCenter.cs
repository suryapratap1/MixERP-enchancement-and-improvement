using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void AddCostCenterField(HtmlGenericControl container)
        {
            using (HtmlGenericControl costCenterDiv = HtmlControlHelper.GetField())
            {
                costCenterDiv.ID = "CostCenterDiv";

                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.CostCenter, "CostCenterSelect"))
                {
                    costCenterDiv.Controls.Add(label);
                }

                using (HtmlSelect costCenterSelect = new HtmlSelect())
                {
                    costCenterSelect.ID = "CostCenterSelect";
                    costCenterDiv.Controls.Add(costCenterSelect);
                }

                container.Controls.Add(costCenterDiv);
            }
        }
    }
}