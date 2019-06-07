using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Finance.Confirmation
{
    public partial class JournalVoucher : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (Checklist checklist = new Checklist())
            {
                checklist.Text = Titles.JournalVoucherEntry;
                checklist.DisplayWithdrawButton = true;
                checklist.DisplayPrintGlEntryButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.AttachmentBookName = "transaction";
                checklist.OverridePath = this.OverridePath;

                checklist.ViewPath = "~/Modules/Finance/JournalVoucher.mix";
                checklist.AddNewPath = "~/Modules/Finance/Entry/JournalVoucher.mix";
                checklist.GlAdvicePath = "~/Modules/Finance/Reports/GLAdviceReport.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}