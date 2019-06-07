using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.PartyControl;
using System;
using MixERP.Net.Framework.Contracts;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Entry
{
    public partial class Receipt : MixERPUserControl, ITransaction
    {
        public string ExchangeRateLocalized()
        {
            return Titles.ExchangeRate;
        }

        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (PartyControl partyControl = new PartyControl())
            {
                this.Placeholder1.Controls.Add(partyControl);
            }

            this.InitializeResourceStrings();
        }

        private void InitializeResourceStrings()
        {
            this.TitleLiteral.Text = Titles.SalesReceipt;
            this.TotalDueAmountInBaseCurrencyLiteral.Text = Titles.TotalDueAmountInBaseCurrency;
            this.BaseCurrencyLiteral.Text = Titles.BaseCurrency;
            this.ReceivedCurrencyLiteral.Text = Titles.ReceivedCurrency;
            this.ReceivedAmountInaboveCurrencyLiteral.Text = Titles.ReceivedAmountInaboveCurrency;
            this.DebitExchangeRateLiteral.Text = Titles.ExchangeRate;
            this.ConvertedToHomeCurrencyLiteral.Text = Titles.ConvertedtoHomeCurrency;
            this.CreditExchangeRateLiteral.Text = Titles.ExchangeRate;
            this.ConvertedToBaseCurrencyLiteral.Text = Titles.ConvertedtoBaseCurrency;
            this.FinalDueAmountInBaseCurrencyLiteral.Text = Titles.FinalDueAmountinBaseCurrency;
            this.SaveLiteral.Text = Titles.Save;
            this.ReceiptTypeLiteral.Text = Titles.ReceiptType;
            this.CostCenterLiteral.Text = Titles.CostCenter;
            this.CashRepositoryLiteral.Text = Titles.CashRepository;
            this.WhichBankLiteral.Text = Titles.WhichBank;
            this.PostedDateLiteral.Text = Titles.PostedDate;

            this.PaymentCardLiteral.Text = Titles.SelectPaymentCard;
            this.MerchantFeeLiteral.Text = Titles.MerchantFeeInPercent;
            this.CustomerPaysFeesLiteral.Text = Titles.CustomerPaysFees;
            this.YesLiteral.Text = Titles.Yes;
            
            this.InstrumentCodeLiteral.Text = Titles.InstrumentCode;
            this.BankTransactionCodeLiteral.Text = Titles.BankTransactionCode;
            this.ReferenceNumberLiteral.Text = Titles.ReferenceNumber;
            this.StatementReferenceLiteral.Text = Titles.StatementReference;
        }
    }
}