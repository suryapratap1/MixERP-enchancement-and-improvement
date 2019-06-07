using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Inventory.Confirmation
{
    public partial class Transfer : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (Checklist checklist = new Checklist())
            {
                checklist.ViewReportButtonText = Titles.ViewThisTransfer;
                checklist.Text = Titles.StockTransferJournal;
                checklist.AttachmentBookName = "transaction";
                checklist.OverridePath = "/Modules/Inventory/Transfer.mix";
                checklist.DisplayWithdrawButton = true;
                checklist.DisplayViewReportButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.ReportPath = "~/Modules/Inventory/Reports/InventoryTransferReport.mix";
                checklist.ViewPath = "/Modules/Inventory/Transfer.mix";
                checklist.AddNewPath = "/Modules/Inventory/Entry/Transfer.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}