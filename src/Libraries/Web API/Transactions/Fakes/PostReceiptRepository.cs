// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.Entities.Transactions;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class PostReceiptRepository : IPostReceiptRepository
    {
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public long LoginId { get; set; }
        public string PartyCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public decimal ExchangeRateDebit { get; set; }
        public decimal ExchangeRateCredit { get; set; }
        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }
        public int CostCenterId { get; set; }
        public int CashRepositoryId { get; set; }
        public DateTime PostedDate { get; set; }
        public long BankAccountId { get; set; }
        public int PaymentCardId { get; set; }
        public string BankInstrumentCode { get; set; }
        public string BankTranCode { get; set; }
        public long CascadingTranId { get; set; }

        public long Execute()
        {
            return 1;
        }
    }
}