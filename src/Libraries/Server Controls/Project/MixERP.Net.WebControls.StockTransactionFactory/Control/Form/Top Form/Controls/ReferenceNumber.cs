using System.Web.UI.HtmlControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddReferenceNumberInputTextField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.ReferenceNumberAbbreviated))
                {
                    field.Controls.Add(label);
                }


                this.referenceNumberInputText = new HtmlInputText();
                this.referenceNumberInputText.ID = "ReferenceNumberInputText";
                this.referenceNumberInputText.MaxLength = 24;

                field.Controls.Add(this.referenceNumberInputText);

                container.Controls.Add(field);
            }
        }
    }
}