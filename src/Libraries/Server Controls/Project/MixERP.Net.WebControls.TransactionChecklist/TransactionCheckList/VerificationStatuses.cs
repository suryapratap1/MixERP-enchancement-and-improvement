using MixERP.Net.Common;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;
using System.Globalization;
using System.Web.UI.WebControls;
using MixERP.Net.TransactionGovernor.Verification;

namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        private void ShowVerificationStatus(string tranId, Label label)
        {
            if (this.HideVerificationMessage)
            {
                return;
            }

            if (this.IsNonGlTransaction)
            {
                return;
            }

            long transactionMasterId = Conversion.TryCastLong(tranId);

            if (transactionMasterId <= 0)
            {
                return;
            }

            Entities.Transactions.Models.VerificationModel model = Status.GetVerificationStatus(this.Catalog, transactionMasterId, this.IsStockTransferRequest);

            if (model == null)
            {
                return;
            }

            switch (model.VerificationStatusId)
            {
                case -3:
                    label.CssClass = "ui block message red";
                    label.Text = string.Format(CultureManager.GetCurrent(), Labels.TransactionRejectedDetails, model.VerifierName, model.VerifiedDate.ToString(CultureManager.GetCurrentUICulture()), model.VerificationReason);
                    break;

                case -2:
                    label.CssClass = "ui block message yellow";
                    label.Text = string.Format(CultureManager.GetCurrent(), Labels.TransactionClosedDetails, model.VerifierName, model.VerifiedDate.ToString(CultureManager.GetCurrentUICulture()), model.VerificationReason);
                    break;

                case -1:
                    label.Text = string.Format(CultureManager.GetCurrent(), Labels.TransactionWithdrawnDetails, model.VerifierName, model.VerifiedDate.ToString(CultureManager.GetCurrentUICulture()), model.VerificationReason);
                    label.CssClass = "ui block message yellow";
                    break;

                case 0:
                    label.Text = Labels.TransactionAwaitingVerification;
                    label.CssClass = "ui block message blue";
                    break;

                case 1:
                    label.Text = string.Format(CultureManager.GetCurrent(), Labels.TransactionAutoApprovedDetails, model.VerifierName, model.VerifiedDate.ToString(CultureManager.GetCurrentUICulture()));
                    label.CssClass = "ui block message green";
                    break;

                case 2:
                    label.Text = string.Format(CultureManager.GetCurrent(), Labels.TransactionApprovedDetails, model.VerifierName, model.VerifiedDate.ToString(CultureManager.GetCurrentUICulture()));
                    label.CssClass = "ui block message green";
                    break;
            }
        }
    }
}