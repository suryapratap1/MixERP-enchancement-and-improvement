using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void AddSaveButton(HtmlGenericControl container)
        {
            using (HtmlInputButton saveButton = new HtmlInputButton())
            {
                saveButton.ID = "SaveButton";
                saveButton.Attributes.Add("class", "small ui red button");
                saveButton.Value = Titles.Save;

                container.Controls.Add(saveButton);
            }
        }
    }
}