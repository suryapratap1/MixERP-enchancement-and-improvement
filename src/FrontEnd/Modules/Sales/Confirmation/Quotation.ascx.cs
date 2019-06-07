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
    public partial class Quotation : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            long transactionMasterId = Conversion.TryCastLong(this.Request["TranId"]);

            using (Checklist checklist = new Checklist())
            {
                checklist.ViewReportButtonText = Titles.ViewThisQuotation;
                checklist.EmailReportButtonText = Titles.EmailThisQuotation;
                checklist.Text = Titles.SalesQuotation;

                checklist.AttachmentFileName = HostingEnvironment.MapPath("/Resource/Documents/" + checklist.Text + "-#" + transactionMasterId + ".pdf");
                checklist.PartyEmailAddress = Data.Helpers.Parties.GetEmailAddress(AppUsers.GetCurrentUserDB(),
                    TranBook.Sales, SubTranBook.Quotation, transactionMasterId);


                checklist.AttachmentBookName = "non-gl-transaction";
                checklist.OverridePath = "/Modules/Sales/Quotation.mix";
                checklist.DisplayViewReportButton = true;
                checklist.DisplayEmailReportButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.IsNonGlTransaction = true;
                checklist.ReportPath = "~/Modules/Sales/Reports/SalesQuotationReport.mix";
                checklist.ViewPath = "/Modules/Sales/Quotation.mix";
                checklist.AddNewPath = "/Modules/Sales/Entry/Quotation.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}