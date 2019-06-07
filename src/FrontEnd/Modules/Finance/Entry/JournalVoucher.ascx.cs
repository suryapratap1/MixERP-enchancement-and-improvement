using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.AttachmentFactory;
using System;
using MixERP.Net.Entities;
using MixERP.Net.Framework.Contracts;

namespace MixERP.Net.Core.Modules.Finance.Entry
{
    public partial class JournalVoucher : MixERPUserControl, ITransaction
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.TitleLabel.Text = Titles.JournalVoucherEntry;
            this.ValueDateLiteral.Text = Titles.ValueDate;
            this.ReferenceNumberLiteral.Text = Titles.ReferenceNumber;
            this.StatementReferenceLiteral.Text = Titles.StatementReference;
            this.AccountNumberLiteral.Text = Titles.AccountNumber;
            this.AccountLiteral.Text = Titles.Account;
            this.CashRepositoryLiteral.Text = Titles.CashRepository;
            this.CurrencyLiteral.Text = Titles.Currency;
            this.DebitLiteral.Text = Titles.Debit;
            this.CreditLiteral.Text = Titles.Credit;
            this.ERLiteral.Text = Titles.ER;
            this.LCDebitLiteral.Text = Titles.LCDebit;
            this.LCCreditLiteral.Text = Titles.LCCredit;
            this.ActionLiteral.Text = Titles.Action;
            this.CostCenterLiteral.Text = Titles.CostCenter;
            this.DebitTotalLiteral.Text = Titles.DebitTotal;
            this.CreditTotalLiteral.Text = Titles.CreditTotal;
            this.PostTransactionLiteral.Text = Titles.PostTransaction;
            this.AddInputButton.Value = Titles.Add;

            this.ValueDateTextBox.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.ValueDateTextBox.Catalog = AppUsers.GetCurrentUserDB();
            this.ValueDateTextBox.Mode = FrequencyType.Today;

            this.BookDateTextBox.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this.BookDateTextBox.Catalog = AppUsers.GetCurrentUserDB();
            this.BookDateTextBox.Mode = FrequencyType.Today;

            using (Attachment attachment = new Attachment(AppUsers.GetCurrentUserDB()))
            {
                this.Placeholder1.Controls.Add(attachment);
            }
        }
    }
}