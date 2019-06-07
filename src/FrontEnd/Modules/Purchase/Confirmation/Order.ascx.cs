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
    public partial class Order : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            long transactionMasterId = Conversion.TryCastLong(this.Request["TranId"]);

            using (Checklist checklist = new Checklist())
            {
                checklist.ViewReportButtonText = Titles.ViewThisOrder;
                checklist.EmailReportButtonText = Titles.EmailThisOrder;
                checklist.Text = Titles.PurchaseOrder;
                checklist.PartyEmailAddress = Data.Helpers.Parties.GetEmailAddress(AppUsers.GetCurrentUserDB(),
                    TranBook.Purchase, SubTranBook.Order, transactionMasterId);

                checklist.AttachmentBookName = "non-gl-transaction";
                checklist.OverridePath = "/Modules/Purchase/Order.mix";
                checklist.DisplayViewReportButton = true;
                checklist.DisplayEmailReportButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.IsNonGlTransaction = true;
                checklist.ReportPath = "~/Modules/Purchase/Reports/PurchaseOrderReport.mix";
                checklist.ViewPath = "/Modules/Purchase/Order.mix";
                checklist.AddNewPath = "/Modules/Purchase/Entry/Order.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}