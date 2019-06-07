using System.Web.UI.HtmlControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddPartyCodeInputTextField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.SelectParty))
                {
                    field.Controls.Add(label);
                }

                this.partyCodeInputText = new HtmlInputText();
                this.partyCodeInputText.ID = "PartyCodeInputText";
                this.partyCodeInputText.Attributes.Add("title", "F2");

                field.Controls.Add(this.partyCodeInputText);
                container.Controls.Add(field);
            }
        }

        private static void AddPartySelectField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel("&nbsp;"))
                {
                    field.Controls.Add(label);
                }

                using (HtmlSelect partySelect = new HtmlSelect())
                {
                    partySelect.ID = "PartySelect";
                    partySelect.Attributes.Add("title", "F2");

                    field.Controls.Add(partySelect);
                }

                container.Controls.Add(field);
            }
        }
    }
}