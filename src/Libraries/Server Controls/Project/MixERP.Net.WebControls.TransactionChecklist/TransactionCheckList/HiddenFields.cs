using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        private HiddenField emailHidden;

        private void AddEmailHidden(HtmlGenericControl p)
        {
            this.emailHidden = new HiddenField();
            this.emailHidden.ID = "EmailHidden";
            this.emailHidden.ClientIDMode = ClientIDMode.Static;

            p.Controls.Add(this.emailHidden);
        }
    }
}