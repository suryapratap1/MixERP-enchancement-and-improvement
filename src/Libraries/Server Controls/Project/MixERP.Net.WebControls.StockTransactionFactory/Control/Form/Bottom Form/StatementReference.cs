using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddStatementReferenceField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.StatementReference, "StatementReferenceTextArea"))
                {
                    field.Controls.Add(label);
                }

                this.statementReferenceTextArea = new HtmlTextArea();
                this.statementReferenceTextArea.ID = "StatementReferenceTextArea";

                field.Controls.Add(this.statementReferenceTextArea);

                container.Controls.Add(field);
            }
        }
    }
}