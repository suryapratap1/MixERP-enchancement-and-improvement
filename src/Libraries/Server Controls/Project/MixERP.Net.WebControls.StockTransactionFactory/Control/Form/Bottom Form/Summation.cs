using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void AddGrandTotalField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.GrandTotal, "GrandTotalInputTextInputText"))
                {
                    field.Controls.Add(label);
                }

                using (HtmlInputText grandTotalInputTextInputText = new HtmlInputText())
                {
                    grandTotalInputTextInputText.ID = "GrandTotalInputText";
                    grandTotalInputTextInputText.Attributes.Add("class", "currency");
                    grandTotalInputTextInputText.Attributes.Add("readonly", "readonly");
                    field.Controls.Add(grandTotalInputTextInputText);
                }

                container.Controls.Add(field);
            }
        }

        private static void AddRunningTotalField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.RunningTotal, "RunningTotalInputText"))
                {
                    field.Controls.Add(label);
                }

                using (HtmlInputText runningTotalInputText = new HtmlInputText())
                {
                    runningTotalInputText.ID = "RunningTotalInputText";
                    runningTotalInputText.Attributes.Add("class", "currency");
                    runningTotalInputText.Attributes.Add("readonly", "readonly");
                    field.Controls.Add(runningTotalInputText);
                }

                container.Controls.Add(field);
            }
        }

        private static void AddTaxTotalField(HtmlGenericControl container)
        {
            using (HtmlGenericControl field = HtmlControlHelper.GetField())
            {
                using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.TaxTotal, "TaxTotalInputText"))
                {
                    field.Controls.Add(label);
                }

                using (HtmlInputText taxTotalInputText = new HtmlInputText())
                {
                    taxTotalInputText.ID = "TaxTotalInputText";
                    taxTotalInputText.Attributes.Add("class", "currency");
                    taxTotalInputText.Attributes.Add("readonly", "readonly");
                    field.Controls.Add(taxTotalInputText);
                }

                container.Controls.Add(field);
            }
        }

        private static void AddTotalFields(HtmlGenericControl container)
        {
            using (HtmlGenericControl fields = HtmlControlHelper.GetFields("three fields"))
            {
                AddRunningTotalField(fields);
                AddTaxTotalField(fields);
                AddGrandTotalField(fields);

                container.Controls.Add(fields);
            }
        }
    }
}