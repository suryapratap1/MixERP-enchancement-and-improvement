using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Purchase.Data.Helpers;
using MixERP.Net.Entities;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Purchase.Confirmation
{
    public partial class GRN : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            long transactionMasterId = Conversion.TryCastLong(this.Request["TranId"]);

            using (Checklist checklist = new Checklist())
            {
                checklist.Text = Titles.GoodsReceiptNote;
                checklist.ViewReportButtonText = Titles.ViewThisNote;
                checklist.EmailReportButtonText = Titles.EmailThisNote;
                checklist.PartyEmailAddress = Parties.GetEmailAddress(AppUsers.GetCurrentUserDB(), TranBook.Purchase,
                    SubTranBook.Receipt, transactionMasterId);

                checklist.AttachmentBookName = "transaction";
                checklist.OverridePath = "/Modules/Purchase/GRN.mix";
                checklist.DisplayWithdrawButton = true;
                checklist.DisplayViewReportButton = true;
                checklist.DisplayEmailReportButton = true;
                checklist.DisplayPrintGlEntryButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.ReportPath = "~/Modules/Purchase/Reports/GRNReport.mix";
                checklist.GlAdvicePath = "~/Modules/Finance/Reports/GLAdviceReport.mix";
                checklist.ViewPath = "/Modules/Purchase/GRN.mix";
                checklist.AddNewPath = "/Modules/Purchase/Entry/GRN.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}