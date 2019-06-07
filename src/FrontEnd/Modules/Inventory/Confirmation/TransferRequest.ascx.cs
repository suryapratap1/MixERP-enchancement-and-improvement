using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Inventory.Confirmation
{
    public partial class TransferRequest : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (Checklist checklist = new Checklist())
            {
                checklist.ViewReportButtonText = Titles.ViewThisRequest;
                checklist.Text = Titles.StockTransferRequest;
                checklist.AttachmentBookName = "inventory.transfer.request";
                checklist.OverridePath = "/Modules/Inventory/TransferRequest.mix";
                checklist.DisplayWithdrawButton = true;
                checklist.DisplayViewReportButton = true;
                checklist.DisplayAttachmentButton = true;

                checklist.IsStockTransferRequest = true;
                
                checklist.ReportPath = "~/Modules/Inventory/Reports/InventoryTransferRequestReport.mix";
                checklist.ViewPath = "/Modules/Inventory/TransferRequest.mix";
                checklist.AddNewPath = "/Modules/Inventory/Entry/TransferRequest.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}