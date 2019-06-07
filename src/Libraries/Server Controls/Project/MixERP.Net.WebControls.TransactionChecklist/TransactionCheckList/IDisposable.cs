namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        private bool disposed;

        public sealed override void Dispose()
        {
            if (!this.disposed)
            {
                this.Dispose(true);
                base.Dispose();
            }
        }

        private void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }

            if (this.checkListContainer != null)
            {
                this.checkListContainer.Dispose();
                this.checkListContainer = null;
            }

            if (this.subTitleHeading != null)
            {
                this.subTitleHeading.Dispose();
                this.subTitleHeading= null;
            }

            if (this.titleLiteral != null)
            {
                this.titleLiteral.Dispose();
                this.titleLiteral = null;
            }

            if (this.verificationLabel != null)
            {
                this.verificationLabel.Dispose();
                this.verificationLabel = null;
            }

            if (this.reasonTextBox != null)
            {
                this.reasonTextBox.Dispose();
                this.reasonTextBox = null;
            }

            if (this.emailLinkButton != null)
            {
                this.emailLinkButton.Dispose();
                this.emailLinkButton = null;
            }

            if (this.messageLabel != null)
            {
                this.messageLabel.Dispose();
                this.messageLabel = null;
            }

            if (this.emailHidden != null)
            {
                this.emailHidden.Dispose();
                this.emailHidden = null;
            }

            if (this.okButton != null)
            {
                this.okButton.Dispose();
                this.okButton = null;
            }


            this.disposed = true;

        }
    }
}