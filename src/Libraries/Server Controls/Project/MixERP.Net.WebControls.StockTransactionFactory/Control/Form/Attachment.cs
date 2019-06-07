using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.AttachmentFactory;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private static void CreateAttachmentPanel(Control container)
        {
            using (HtmlGenericControl header = new HtmlGenericControl("h2"))
            {
                header.ID = "attachmentToggler";
                header.InnerText = Titles.AttachmentsPlus;
                container.Controls.Add(header);
            }

            using (HtmlGenericControl attachmentContainer = new HtmlGenericControl("div"))
            {
                attachmentContainer.ID = "attachment";
                attachmentContainer.Attributes.Add("class", "ui segment initially hidden");


                using (Attachment attachment = new Attachment(AppUsers.GetCurrentUserDB()))
                {
                    attachment.ShowSaveButton = false;
                    attachmentContainer.Controls.Add(attachment);
                }
                container.Controls.Add(attachmentContainer);
            }
        }
    }
}