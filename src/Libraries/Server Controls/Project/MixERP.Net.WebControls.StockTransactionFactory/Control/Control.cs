using MixERP.Net.Common.Helpers;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    [ToolboxData("<{0}:StockTransactionForm runat=server></{0}:StockTransactionForm>")]
    public partial class StockTransactionForm : CompositeControl
    {
        protected override void CreateChildControls()
        {
            this.placeHolder = new PlaceHolder();

            this.CreateTitle(this.placeHolder);
            this.CreateTopFormPanel(this.placeHolder);

            if (!this.Page.IsPostBack)
            {
                SessionHelper.RemoveSessionKey(this.ID);
            }

            this.AddStylesheet();
            this.CreateGrid(this.placeHolder);
            CreateErrorLabel(this.placeHolder);
            CreateAttachmentPanel(this.placeHolder);
            this.CreateBottomFormPanel(this.placeHolder);
            this.CreateHiddenFields(this.placeHolder);
            CreateErrorLabelBottom(this.placeHolder);
            this.AddJavascript();
            this.RegisterJavascript();

            this.Controls.Add(this.placeHolder);
        }

        protected override void RecreateChildControls()
        {
            this.EnsureChildControls();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            this.EnsureChildControls();
            this.placeHolder.RenderControl(writer);
        }
    }
}