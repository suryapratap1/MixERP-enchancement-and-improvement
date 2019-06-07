using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddTopFormControls(HtmlGenericControl container)
        {
            this.AddDateTextBoxField(container);

            if (this.ShowStore)
            {
                AddStoreSelectField(container);
            }

            this.AddPartyCodeInputTextField(container);
            AddPartySelectField(container);

            if (this.ShowPriceTypes)
            {
                AddPriceTypeSelectField(container);
            }

            this.AddReferenceNumberInputTextField(container);

            if (this.ShowTransactionType)
            {
                this.AddCashTransactionDivField(container);
            }

            if (this.ShowPaymentTerms)
            {
                this.AddPaymentTermSelectField(container);
            }
        }

        private int CountTopFormControls()
        {
            return 4
                   + (this.ShowStore ? 1 : 0)
                   + (this.ShowPriceTypes ? 1 : 0)
                   + (this.ShowTransactionType ? 1 : 0)
                   + (this.ShowPaymentTerms ? 1 : 0);
        }
    }
}