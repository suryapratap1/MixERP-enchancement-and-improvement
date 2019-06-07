using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateErrorLabel(Control container)
        {
            using (HtmlGenericControl errorLabel = new HtmlGenericControl("span"))
            {
                errorLabel.ID = "ErrorLabel";
                errorLabel.Attributes.Add("class", "big error");

                container.Controls.Add(errorLabel);
            }
        }

        private static void CreateErrorLabelBottom(Control container)
        {
            using (HtmlGenericControl errorLabel = new HtmlGenericControl("span"))
            {
                errorLabel.ID = "ErrorLabelBottom";
                errorLabel.Attributes.Add("class", "big error");

                container.Controls.Add(errorLabel);
            }
        }
    }
}