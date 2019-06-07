// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "transactions.post_receipt(_user_id integer, _office_id integer, _login_id bigint, _party_code character varying, _currency_code character varying, _amount money_strict, _exchange_rate_debit decimal_strict, _exchange_rate_credit decimal_strict, _reference_number character varying, _statement_reference character varying, _cost_center_id integer, _cash_repository_id integer, _posted_date date, _bank_account_id bigint, _payment_card_id integer, _bank_instrument_code character varying, _bank_tran_code character varying, _cascading_tran_id bigint)" on the database.
    /// </summary>
    public class PostReceiptProcedure : DbAccess, IPostReceiptRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "post_receipt";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
        public long _LoginId { get; set; }
        /// <summary>
        /// User id of application user accessing this table.
        /// </summary>
        public int _UserId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string _Catalog { get; set; }

        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.post_receipt".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.post_receipt".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_login_id" argument of the function "transactions.post_receipt".
        /// </summary>
        public long LoginId { get; set; }
        /// <summary>
        /// Maps to "_party_code" argument of the function "transactions.post_receipt".
        /// </summary>
        public string PartyCode { get; set; }
        /// <summary>
        /// Maps to "_currency_code" argument of the function "transactions.post_receipt".
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Maps to "_amount" argument of the function "transactions.post_receipt".
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Maps to "_exchange_rate_debit" argument of the function "transactions.post_receipt".
        /// </summary>
        public decimal ExchangeRateDebit { get; set; }
        /// <summary>
        /// Maps to "_exchange_rate_credit" argument of the function "transactions.post_receipt".
        /// </summary>
        public decimal ExchangeRateCredit { get; set; }
        /// <summary>
        /// Maps to "_reference_number" argument of the function "transactions.post_receipt".
        /// </summary>
        public string ReferenceNumber { get; set; }
        /// <summary>
        /// Maps to "_statement_reference" argument of the function "transactions.post_receipt".
        /// </summary>
        public string StatementReference { get; set; }
        /// <summary>
        /// Maps to "_cost_center_id" argument of the function "transactions.post_receipt".
        /// </summary>
        public int CostCenterId { get; set; }
        /// <summary>
        /// Maps to "_cash_repository_id" argument of the function "transactions.post_receipt".
        /// </summary>
        public int CashRepositoryId { get; set; }
        /// <summary>
        /// Maps to "_posted_date" argument of the function "transactions.post_receipt".
        /// </summary>
        public DateTime PostedDate { get; set; }
        /// <summary>
        /// Maps to "_bank_account_id" argument of the function "transactions.post_receipt".
        /// </summary>
        public long BankAccountId { get; set; }
        /// <summary>
        /// Maps to "_payment_card_id" argument of the function "transactions.post_receipt".
        /// </summary>
        public int PaymentCardId { get; set; }
        /// <summary>
        /// Maps to "_bank_instrument_code" argument of the function "transactions.post_receipt".
        /// </summary>
        public string BankInstrumentCode { get; set; }
        /// <summary>
        /// Maps to "_bank_tran_code" argument of the function "transactions.post_receipt".
        /// </summary>
        public string BankTranCode { get; set; }
        /// <summary>
        /// Maps to "_cascading_tran_id" argument of the function "transactions.post_receipt".
        /// </summary>
        public long CascadingTranId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_receipt(_user_id integer, _office_id integer, _login_id bigint, _party_code character varying, _currency_code character varying, _amount money_strict, _exchange_rate_debit decimal_strict, _exchange_rate_credit decimal_strict, _reference_number character varying, _statement_reference character varying, _cost_center_id integer, _cash_repository_id integer, _posted_date date, _bank_account_id bigint, _payment_card_id integer, _bank_instrument_code character varying, _bank_tran_code character varying, _cascading_tran_id bigint)" on the database.
        /// </summary>
        public PostReceiptProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.post_receipt(_user_id integer, _office_id integer, _login_id bigint, _party_code character varying, _currency_code character varying, _amount money_strict, _exchange_rate_debit decimal_strict, _exchange_rate_credit decimal_strict, _reference_number character varying, _statement_reference character varying, _cost_center_id integer, _cash_repository_id integer, _posted_date date, _bank_account_id bigint, _payment_card_id integer, _bank_instrument_code character varying, _bank_tran_code character varying, _cascading_tran_id bigint)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.post_receipt".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.post_receipt".</param>
        /// <param name="loginId">Enter argument value for "_login_id" parameter of the function "transactions.post_receipt".</param>
        /// <param name="partyCode">Enter argument value for "_party_code" parameter of the function "transactions.post_receipt".</param>
        /// <param name="currencyCode">Enter argument value for "_currency_code" parameter of the function "transactions.post_receipt".</param>
        /// <param name="amount">Enter argument value for "_amount" parameter of the function "transactions.post_receipt".</param>
        /// <param name="exchangeRateDebit">Enter argument value for "_exchange_rate_debit" parameter of the function "transactions.post_receipt".</param>
        /// <param name="exchangeRateCredit">Enter argument value for "_exchange_rate_credit" parameter of the function "transactions.post_receipt".</param>
        /// <param name="referenceNumber">Enter argument value for "_reference_number" parameter of the function "transactions.post_receipt".</param>
        /// <param name="statementReference">Enter argument value for "_statement_reference" parameter of the function "transactions.post_receipt".</param>
        /// <param name="costCenterId">Enter argument value for "_cost_center_id" parameter of the function "transactions.post_receipt".</param>
        /// <param name="cashRepositoryId">Enter argument value for "_cash_repository_id" parameter of the function "transactions.post_receipt".</param>
        /// <param name="postedDate">Enter argument value for "_posted_date" parameter of the function "transactions.post_receipt".</param>
        /// <param name="bankAccountId">Enter argument value for "_bank_account_id" parameter of the function "transactions.post_receipt".</param>
        /// <param name="paymentCardId">Enter argument value for "_payment_card_id" parameter of the function "transactions.post_receipt".</param>
        /// <param name="bankInstrumentCode">Enter argument value for "_bank_instrument_code" parameter of the function "transactions.post_receipt".</param>
        /// <param name="bankTranCode">Enter argument value for "_bank_tran_code" parameter of the function "transactions.post_receipt".</param>
        /// <param name="cascadingTranId">Enter argument value for "_cascading_tran_id" parameter of the function "transactions.post_receipt".</param>
        public PostReceiptProcedure(int userId, int officeId, long loginId, string partyCode, string currencyCode, decimal amount, decimal exchangeRateDebit, decimal exchangeRateCredit, string referenceNumber, string statementReference, int costCenterId, int cashRepositoryId, DateTime postedDate, long bankAccountId, int paymentCardId, string bankInstrumentCode, string bankTranCode, long cascadingTranId)
        {
            this.UserId = userId;
            this.OfficeId = officeId;
            this.LoginId = loginId;
            this.PartyCode = partyCode;
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
            this.ExchangeRateDebit = exchangeRateDebit;
            this.ExchangeRateCredit = exchangeRateCredit;
            this.ReferenceNumber = referenceNumber;
            this.StatementReference = statementReference;
            this.CostCenterId = costCenterId;
            this.CashRepositoryId = cashRepositoryId;
            this.PostedDate = postedDate;
            this.BankAccountId = bankAccountId;
            this.PaymentCardId = paymentCardId;
            this.BankInstrumentCode = bankInstrumentCode;
            this.BankTranCode = bankTranCode;
            this.CascadingTranId = cascadingTranId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.post_receipt".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"PostReceiptProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.post_receipt(@UserId, @OfficeId, @LoginId, @PartyCode, @CurrencyCode, @Amount, @ExchangeRateDebit, @ExchangeRateCredit, @ReferenceNumber, @StatementReference, @CostCenterId, @CashRepositoryId, @PostedDate, @BankAccountId, @PaymentCardId, @BankInstrumentCode, @BankTranCode, @CascadingTranId);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@1::integer");
            query = query.ReplaceWholeWord("@LoginId", "@2::bigint");
            query = query.ReplaceWholeWord("@PartyCode", "@3::character varying");
            query = query.ReplaceWholeWord("@CurrencyCode", "@4::character varying");
            query = query.ReplaceWholeWord("@Amount", "@5::money_strict");
            query = query.ReplaceWholeWord("@ExchangeRateDebit", "@6::decimal_strict");
            query = query.ReplaceWholeWord("@ExchangeRateCredit", "@7::decimal_strict");
            query = query.ReplaceWholeWord("@ReferenceNumber", "@8::character varying");
            query = query.ReplaceWholeWord("@StatementReference", "@9::character varying");
            query = query.ReplaceWholeWord("@CostCenterId", "@10::integer");
            query = query.ReplaceWholeWord("@CashRepositoryId", "@11::integer");
            query = query.ReplaceWholeWord("@PostedDate", "@12::date");
            query = query.ReplaceWholeWord("@BankAccountId", "@13::bigint");
            query = query.ReplaceWholeWord("@PaymentCardId", "@14::integer");
            query = query.ReplaceWholeWord("@BankInstrumentCode", "@15::character varying");
            query = query.ReplaceWholeWord("@BankTranCode", "@16::character varying");
            query = query.ReplaceWholeWord("@CascadingTranId", "@17::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.LoginId);
            parameters.Add(this.PartyCode);
            parameters.Add(this.CurrencyCode);
            parameters.Add(this.Amount);
            parameters.Add(this.ExchangeRateDebit);
            parameters.Add(this.ExchangeRateCredit);
            parameters.Add(this.ReferenceNumber);
            parameters.Add(this.StatementReference);
            parameters.Add(this.CostCenterId);
            parameters.Add(this.CashRepositoryId);
            parameters.Add(this.PostedDate);
            parameters.Add(this.BankAccountId);
            parameters.Add(this.PaymentCardId);
            parameters.Add(this.BankInstrumentCode);
            parameters.Add(this.BankTranCode);
            parameters.Add(this.CascadingTranId);

            return Factory.Scalar<long>(this._Catalog, query, parameters.ToArray());
        }


    }
}