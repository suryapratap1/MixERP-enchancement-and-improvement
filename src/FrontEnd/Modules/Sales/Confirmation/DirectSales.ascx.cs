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
    public partial class DirectSales : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            long transactionMasterId = Conversion.TryCastLong(this.Request["TranId"]);

            using (Checklist checklist = new Checklist())
            {
                checklist.ViewReportButtonText = Titles.ViewThisInvoice;
                checklist.EmailReportButtonText = Titles.EmailThisInvoice;
                checklist.CustomerReportButtonText = Titles.ViewCustomerCopy;
                checklist.Text = Titles.DirectSales;

                checklist.AttachmentFileName = HostingEnvironment.MapPath("/Resource/Documents/" + checklist.Text + "-#" + transactionMasterId + ".pdf");
                checklist.PartyEmailAddress = Data.Helpers.Parties.GetEmailAddress(AppUsers.GetCurrentUserDB(),
                    TranBook.Sales, SubTranBook.Direct, transactionMasterId);
                checklist.AttachmentBookName = "transaction";
                checklist.OverridePath = "/Modules/Sales/DirectSales.mix";
                checklist.DisplayWithdrawButton = true;
                checklist.DisplayViewReportButton = true;
                checklist.DisplayEmailReportButton = true;
                checklist.DisplayCustomerReportButton = true;
                checklist.DisplayPrintReceiptButton = true;
                checklist.DisplayPrintGlEntryButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.ReportPath = "~/Modules/Sales/Reports/DirectSalesInvoiceReport.mix";
                checklist.CustomerReportPath = "~/Modules/Sales/Reports/CustomerInvoiceReport.mix";
                checklist.ReceiptAdvicePath = "~/Modules/Sales/Reports/ReceiptReport.mix";
                checklist.GlAdvicePath = "~/Modules/Finance/Reports/GLAdviceReport.mix";
                checklist.ViewPath = "/Modules/Sales/DirectSales.mix";
                checklist.AddNewPath = "/Modules/Sales/Entry/DirectSales.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}