namespace MixERP.Net.WebControls.Common
{
    public partial class DateTextBox
    {
        private bool disposed;

        public override void Dispose()
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

            if (this.compareValidator != null)
            {
                this.compareValidator.Dispose();
                this.compareValidator = null;
            }

            if (this.maxDateCompareValidator != null)
            {
                this.maxDateCompareValidator.Dispose();
                this.maxDateCompareValidator = null;
            }

            if (this.requiredValidator != null)
            {
                this.requiredValidator.Dispose();
                this.requiredValidator = null;
            }

            if (this.textBox != null)
            {
                this.textBox.Dispose();
                this.textBox = null;
            }

            this.disposed = true;
        }
    }
}