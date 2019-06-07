using MixERP.Net.Common.Helpers;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void CreateBottomFormPanel(Control container)
        {
            using (HtmlGenericControl formContainer = new HtmlGenericControl("div"))
            {
                formContainer.Attributes.Add("style", "width:500px");

                using (HtmlGenericControl formSegment = HtmlControlHelper.GetFormSegment()) //ui page form segment
                {
                    if (this.ShowShippingInformation)
                    {
                        AddShippingAddressTextAreaField(formSegment);
                    }

                    AddTotalFields(formSegment);

                    if (this.ShowCostCenter)
                    {
                        AddCostCenterField(formSegment);
                    }

                    if (this.ShowSalesAgents)
                    {
                        AddSalespersonField(formSegment);
                    }

                    this.AddStatementReferenceField(formSegment);
                    AddSaveButton(formSegment);

                    formContainer.Controls.Add(formSegment);
                }

                container.Controls.Add(formContainer);
            }
        }
    }
}