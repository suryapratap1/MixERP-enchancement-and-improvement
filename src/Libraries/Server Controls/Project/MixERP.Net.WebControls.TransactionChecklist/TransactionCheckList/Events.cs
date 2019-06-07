using MixERP.Net.Common;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.TransactionChecklist.Helpers;
using System;
using System.Globalization;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.i18n;
using MixERP.Net.TransactionGovernor.Verification;

namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        private void EmailLinkButton_Click(object sender, EventArgs e)
        {
            string tranId = this.GetTranId();

            string emailTemplate = this.emailHidden.Value;

            if (string.IsNullOrWhiteSpace(tranId))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(emailTemplate))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(this.PartyEmailAddress))
            {
                return;
            }

            if (Messaging.Email.Helpers.Config.IsEnabled(AppUsers.GetCurrentUserDB()))
            {
                EmailHelper email = new EmailHelper(this.Catalog, emailTemplate, this.Text + " #" + tranId, this.PartyEmailAddress, this.AttachmentFileName);
                email.SendEmail();

                this.subTitleHeading.InnerText = string.Format(CultureManager.GetCurrent(), Labels.EmailSentConfirmation, this.PartyEmailAddress);
                return;
            }

            this.subTitleHeading.Attributes.Add("class", "ui red header");
            this.subTitleHeading.InnerText = Warnings.CannotSendEmailSMTPInvalid;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.RestrictedTransactionMode)
            {
                this.messageLabel.Text = Labels.CannotWithdrawTransaction;
                this.messageLabel.CssClass = "ui block message red vpad12";
                return;
            }

            string tranId = this.GetTranId();

            if (string.IsNullOrWhiteSpace(tranId))
            {
                return;
            }

            if (this.IsNonGlTransaction)
            {
                this.messageLabel.Text = Labels.CannotWithdrawNotValidGLTransaction;
                this.messageLabel.CssClass = "ui block message red vpad12";
                return;
            }

            DateTime transactionDate = DateTime.Now;
            long transactionMasterId = Conversion.TryCastLong(tranId);

            Entities.Transactions.Models.VerificationModel model = Status.GetVerificationStatus(this.Catalog, transactionMasterId, this.IsStockTransferRequest);
            if (
                model.VerificationStatusId.Equals(0) //Awaiting verification
                ||
                model.VerificationStatusId.Equals(1) //Automatically Approved by Workflow
                )
            {
                //Withdraw this transaction.
                if (transactionMasterId > 0)
                {
                    if (Withdrawal.WithdrawTransaction(this.Catalog, this.IsStockTransferRequest, transactionMasterId, this.UserId, this.reasonTextBox.Text))
                    {
                        this.messageLabel.Text = string.Format(CultureManager.GetCurrent(), Labels.TransactionWithdrawnMessage, transactionDate.ToShortDateString());
                        this.messageLabel.CssClass = "ui block message yellow vpad12";
                    }
                }
            }
            else
            {
                this.messageLabel.Text = Labels.CannotWithdrawTransaction;
                this.messageLabel.CssClass = "ui block message red vpad12";
            }

            this.ShowVerificationStatus(tranId, this.verificationLabel);
        }
    }
}