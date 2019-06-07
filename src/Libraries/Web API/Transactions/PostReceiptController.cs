// ReSharper disable All
using MixERP.Net.Framework;
using MixERP.Net.Entities.Transactions;
using MixERP.Net.Schemas.Transactions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using PetaPoco;
using MixERP.Net.EntityParser;
namespace MixERP.Net.Api.Transactions
{
    /// <summary>
    /// Provides a direct HTTP access to execute the function PostReceipt.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/procedures/post-receipt")]
    public class PostReceiptController : ApiController
    {
        /// <summary>
        /// Login id of application user accessing this API.
        /// </summary>
        public long _LoginId { get; set; }

        /// <summary>
        /// User id of application user accessing this API.
        /// </summary>
        public int _UserId { get; set; }

        /// <summary>
        /// Currently logged in office id of application user accessing this API.
        /// </summary>
        public int _OfficeId { get; set; }

        /// <summary>
        /// The name of the database where queries are being executed on.
        /// </summary>
        public string _Catalog { get; set; }

        /// <summary>
        ///     The PostReceipt repository.
        /// </summary>
        private readonly IPostReceiptRepository repository;

        public class Annotation
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
        }


        public PostReceiptController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();

            this.repository = new PostReceiptProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        public PostReceiptController(IPostReceiptRepository repository, string catalog, LoginView view)
        {
            this._LoginId = view.LoginId.ToLong();
            this._UserId = view.UserId.ToInt();
            this._OfficeId = view.OfficeId.ToInt();
            this._Catalog = catalog;

            this.repository = repository;
        }

        /// <summary>
        ///     Creates meta information of "post receipt" annotation.
        /// </summary>
        /// <returns>Returns the "post receipt" annotation meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("annotation")]
        [Route("~/api/transactions/procedures/post-receipt/annotation")]
        public EntityView GetAnnotation()
        {
            if (this._LoginId == 0)
            {
                return new EntityView();
            }
            return new EntityView
            {
                Columns = new List<EntityColumn>()
                                {
                                        new EntityColumn { ColumnName = "_user_id",  PropertyName = "UserId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_office_id",  PropertyName = "OfficeId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_login_id",  PropertyName = "LoginId",  DataType = "long",  DbDataType = "bigint",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_party_code",  PropertyName = "PartyCode",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_currency_code",  PropertyName = "CurrencyCode",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_amount",  PropertyName = "Amount",  DataType = "decimal",  DbDataType = "money_strict",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_exchange_rate_debit",  PropertyName = "ExchangeRateDebit",  DataType = "decimal",  DbDataType = "decimal_strict",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_exchange_rate_credit",  PropertyName = "ExchangeRateCredit",  DataType = "decimal",  DbDataType = "decimal_strict",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_reference_number",  PropertyName = "ReferenceNumber",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_statement_reference",  PropertyName = "StatementReference",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_cost_center_id",  PropertyName = "CostCenterId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_cash_repository_id",  PropertyName = "CashRepositoryId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_posted_date",  PropertyName = "PostedDate",  DataType = "DateTime",  DbDataType = "date",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_bank_account_id",  PropertyName = "BankAccountId",  DataType = "long",  DbDataType = "bigint",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_payment_card_id",  PropertyName = "PaymentCardId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_bank_instrument_code",  PropertyName = "BankInstrumentCode",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_bank_tran_code",  PropertyName = "BankTranCode",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_cascading_tran_id",  PropertyName = "CascadingTranId",  DataType = "bigint DEFAULT NULL::bigint",  DbDataType = "bigint DEFAULT NULL::bigint",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 }
                                }
            };
        }




        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/transactions/procedures/post-receipt/execute")]
        public long Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.repository.UserId = annotation.UserId;
                this.repository.OfficeId = annotation.OfficeId;
                this.repository.LoginId = annotation.LoginId;
                this.repository.PartyCode = annotation.PartyCode;
                this.repository.CurrencyCode = annotation.CurrencyCode;
                this.repository.Amount = annotation.Amount;
                this.repository.ExchangeRateDebit = annotation.ExchangeRateDebit;
                this.repository.ExchangeRateCredit = annotation.ExchangeRateCredit;
                this.repository.ReferenceNumber = annotation.ReferenceNumber;
                this.repository.StatementReference = annotation.StatementReference;
                this.repository.CostCenterId = annotation.CostCenterId;
                this.repository.CashRepositoryId = annotation.CashRepositoryId;
                this.repository.PostedDate = annotation.PostedDate;
                this.repository.BankAccountId = annotation.BankAccountId;
                this.repository.PaymentCardId = annotation.PaymentCardId;
                this.repository.BankInstrumentCode = annotation.BankInstrumentCode;
                this.repository.BankTranCode = annotation.BankTranCode;
                this.repository.CascadingTranId = annotation.CascadingTranId;


                return this.repository.Execute();
            }
            catch (UnauthorizedException)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden));
            }
            catch (MixERPException ex)
            {
                throw new HttpResponseException(new HttpResponseMessage
                {
                    Content = new StringContent(ex.Message),
                    StatusCode = HttpStatusCode.InternalServerError
                });
            }
            catch
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError));
            }
        }
    }
}