using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void AddSalespersonField(HtmlGenericControl container)
        {
            using (HtmlGenericControl salespersonDiv = HtmlControlHelper.GetField())
            {
                salespersonDiv.ID = "SalespersonDiv";

                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.Salesperson, "SalesPersonSelect"))
                {
                    salespersonDiv.Controls.Add(label);
                }

                using (HtmlSelect salesPersonSelect = new HtmlSelect())
                {
                    salesPersonSelect.ID = "SalesPersonSelect";
                    salespersonDiv.Controls.Add(salesPersonSelect);
                }


                container.Controls.Add(salespersonDiv);
            }
        }
    }
}