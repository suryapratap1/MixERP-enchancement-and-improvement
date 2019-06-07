// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IPostReceiptRepository
    {

        int UserId { get; set; }
        int OfficeId { get; set; }
        long LoginId { get; set; }
        string PartyCode { get; set; }
        string CurrencyCode { get; set; }
        decimal Amount { get; set; }
        decimal ExchangeRateDebit { get; set; }
        decimal ExchangeRateCredit { get; set; }
        string ReferenceNumber { get; set; }
        string StatementReference { get; set; }
        int CostCenterId { get; set; }
        int CashRepositoryId { get; set; }
        DateTime PostedDate { get; set; }
        long BankAccountId { get; set; }
        int PaymentCardId { get; set; }
        string BankInstrumentCode { get; set; }
        string BankTranCode { get; set; }
        long CascadingTranId { get; set; }

        /// <summary>
        /// Prepares and executes IPostReceiptRepository.
        /// </summary>
        long Execute();
    }
}