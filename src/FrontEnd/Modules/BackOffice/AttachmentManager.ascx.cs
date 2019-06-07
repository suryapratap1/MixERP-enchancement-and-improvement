using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.AttachmentFactory;
using System;

namespace MixERP.Net.Core.Modules.BackOffice
{
    public partial class AttachmentManager : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            if (!this.IsRestrictedMode)
            {
                this.TitleLiteral.Text = Titles.UploadAttachments;

                using (Attachment attachment = new Attachment(AppUsers.GetCurrentUserDB()))
                {
                    attachment.ShowSaveButton = true;
                    this.Placeholder1.Controls.Add(attachment);
                }
            }

            this.SubTitleLiteral.Text = Titles.ViewAttachments;
            this.OKLiteral.Text = Titles.OK;
            this.SetOverridePath();
        }

        private void SetOverridePath()
        {
            string overridePath = this.Page.Request.QueryString["OverridePath"];

            if (!string.IsNullOrWhiteSpace(overridePath))
            {
                this.OverridePath = overridePath;
            }
        }
    }
}