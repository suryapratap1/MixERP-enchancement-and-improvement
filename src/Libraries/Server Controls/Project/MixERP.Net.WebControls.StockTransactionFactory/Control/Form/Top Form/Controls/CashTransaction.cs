using System.Web.UI.HtmlControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddCashTransactionDivField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel("&nbsp;"))
                {
                    field.Controls.Add(label);
                }

                using (HtmlGenericControl toggleCheckBox = HtmlControlHelper.GetToggleCheckBox())
                {
                    toggleCheckBox.ID = "CashTransactionDiv";
                    using (HtmlInputCheckBox cashTransactionInputCheckBox = new HtmlInputCheckBox())
                    {
                        cashTransactionInputCheckBox.ID = "CashTransactionInputCheckBox";
                        cashTransactionInputCheckBox.Attributes.Add("checked", "checked");
                        toggleCheckBox.Controls.Add(cashTransactionInputCheckBox);
                    }

                    using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.CashTransaction))
                    {
                        toggleCheckBox.Controls.Add(label);
                    }

                    field.Controls.Add(toggleCheckBox);
                }

                container.Controls.Add(field);
            }
        }
    }
}