using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        private Label messageLabel;

        private void AddMessageLabel(HtmlGenericControl p)
        {
            this.messageLabel = new Label();
            p.Controls.Add(this.messageLabel);
        }
    }
}