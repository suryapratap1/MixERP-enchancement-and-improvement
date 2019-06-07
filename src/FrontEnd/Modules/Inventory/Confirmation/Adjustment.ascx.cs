using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Inventory.Confirmation
{
    public partial class Adjustment : TransactionCheckListControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (Checklist checklist = new Checklist())
            {
                checklist.ViewReportButtonText = Titles.ViewThisAdjustment;
                checklist.Text = Titles.StockAdjustment;
                checklist.AttachmentBookName = "transaction";
                checklist.OverridePath = "/Modules/Inventory/Adjustment.mix";
                checklist.DisplayWithdrawButton = true;
                checklist.DisplayViewReportButton = true;
                checklist.DisplayAttachmentButton = true;
                checklist.DisplayPrintGlEntryButton = true;
                checklist.ReportPath = "~/Modules/Inventory/Reports/InventoryAdjustmentReport.mix";
                checklist.ViewPath = "/Modules/Inventory/Adjustment.mix";
                checklist.GlAdvicePath = "~/Modules/Finance/Reports/GLAdviceReport.mix";
                checklist.AddNewPath = "/Modules/Inventory/Entry/Adjustment.mix";
                checklist.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
                checklist.RestrictedTransactionMode = this.IsRestrictedMode;

                this.Placeholder1.Controls.Add(checklist);
            }
        }
    }
}