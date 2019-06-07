using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Purchase.Confirmation
{
    public partial class Return : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            long transactionMasterId = Conversion.TryCastLong(this.Request["TranId"]);

            using (Checklist checklist = new Checklist())
            {
                checklist.Text = Titles.PurchaseReturn;
                checklist.ViewReportButtonText = Titles.ViewThisReturn;
                checklist.EmailReportButtonText = Titles.EmailThisReturn;
                checklist.PartyEmailAddress = Data.Helpers.Parties.GetEmailAddress(AppUsers.GetCurrentUserDB(),
                    TranBook.Purchase, SubTranBook.Return, transactionMasterId);
                checklist.AttachmentBookName = "transaction";
                checklist.OverridePath = "/Modules/Purchase/Return.mix";
                checklist.DisplayWithdrawButton = true;
                checklist.DisplayViewReportButton = true;
                checklist.DisplayEmailReportButton = true;
                checklist.DisplayPrintGlEntryButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.ReportPath = "~/Modules/Purchase/Reports/PurchaseReturnReport.mix";
                checklist.GlAdvicePath = "~/Modules/Finance/Reports/GLAdviceReport.mix";
                checklist.ViewPath = "/Modules/Purchase/Return.mix";
                checklist.AddNewPath = "/Modules/Purchase/Entry/Return.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}