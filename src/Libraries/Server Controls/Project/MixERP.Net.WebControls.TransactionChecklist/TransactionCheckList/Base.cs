using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.TransactionChecklist
{
    [ToolboxData("<{0}:TransactionChecklistForm runat=server></{0}:TransactionChecklistForm>")]
    public partial class TransactionChecklistForm : CompositeControl
    {
        private HtmlGenericControl checkListContainer;

        protected override void CreateChildControls()
        {
            this.checkListContainer = new HtmlGenericControl();
            this.AddHeader(this.checkListContainer);
            this.AddButtons(this.checkListContainer);
            this.AddWidthdrawDiv(this.checkListContainer);
            this.AddEmailHidden(this.checkListContainer);
            this.AddMessageLabel(this.checkListContainer);
            this.AddScript();

            this.Controls.Add(this.checkListContainer);
        }

        protected override void RecreateChildControls()
        {
            this.EnsureChildControls();
        }
    }
}