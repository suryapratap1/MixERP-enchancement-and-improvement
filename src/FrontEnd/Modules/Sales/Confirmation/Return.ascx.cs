using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;
using System.Web.Hosting;

namespace MixERP.Net.Core.Modules.Sales.Confirmation
{
    public partial class Return : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            long transactionMasterId = Conversion.TryCastLong(this.Request["TranId"]);

            using (Checklist checklist = new Checklist())
            {
                checklist.Text = Titles.SalesReturn;
                checklist.ViewReportButtonText = Titles.ViewThisReturn;
                checklist.EmailReportButtonText = Titles.EmailThisReturn;
                checklist.AttachmentFileName = HostingEnvironment.MapPath("/Resource/Documents/" + checklist.Text + "-#" + transactionMasterId + ".pdf");
                checklist.PartyEmailAddress = Data.Helpers.Parties.GetEmailAddress(AppUsers.GetCurrentUserDB(),
                    TranBook.Sales, SubTranBook.Return, transactionMasterId);
                checklist.AttachmentBookName = "transaction";
                checklist.OverridePath = "~/Modules/Sales/Return.mix";
                checklist.DisplayWithdrawButton = true;
                checklist.DisplayViewReportButton = true;
                checklist.DisplayEmailReportButton = true;
                checklist.DisplayPrintGlEntryButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.ReportPath = "~/Modules/Sales/Reports/SalesReturnReport.mix";
                checklist.GlAdvicePath = "~/Modules/Finance/Reports/GLAdviceReport.mix";
                checklist.ViewPath = "~/Modules/Sales/Return.mix";
                checklist.AddNewPath = "~/Modules/Sales/Entry/Return.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}