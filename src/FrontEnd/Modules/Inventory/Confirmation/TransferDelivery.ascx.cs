using System;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.Core.Modules.Inventory.Confirmation
{
    public partial class TransferDelivery : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (Checklist checklist = new Checklist())
            {
                checklist.ViewReportButtonText = Titles.ViewThisDelivery;
                checklist.Text = Titles.StockTransferDelivery;
                checklist.AttachmentBookName = "inventory.transfer.delivery";
                checklist.OverridePath = "/Modules/Inventory/TransferDelivery.mix";
                checklist.DisplayViewReportButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.HideVerificationMessage = true;
                checklist.ReportPath = "~/Modules/Inventory/Reports/InventoryTransferDeliveryReport.mix";
                checklist.ViewPath = "/Modules/Inventory/TransferDelivery.mix";
                checklist.AddNewPath = "/Modules/Inventory/Entry/TransferDelivery.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}