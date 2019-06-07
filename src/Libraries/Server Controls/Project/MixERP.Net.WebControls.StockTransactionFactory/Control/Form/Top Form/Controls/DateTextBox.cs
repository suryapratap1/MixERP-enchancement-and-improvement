using System.Web.UI.HtmlControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Entities;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.Common;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddDateTextBoxField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.ValueDate))
                {
                    field.Controls.Add(label);
                }

                this.dateTextBox = new DateTextBox();
                this.dateTextBox.ID = "DateTextBox";
                this.dateTextBox.OfficeId = this.OfficeId;
                this.dateTextBox.Mode = FrequencyType.Today;
                this.dateTextBox.CssClass = "date";
                this.dateTextBox.Catalog = this.Catalog;
                this.dateTextBox.OfficeId = this.OfficeId;

                field.Controls.Add(this.dateTextBox);
                container.Controls.Add(field);
            }
        }
    }
}