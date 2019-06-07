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
    /// Provides a direct HTTP access to execute the function GetInvoiceAmount.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/procedures/get-invoice-amount")]
    public class GetInvoiceAmountController : ApiController
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
        ///     The GetInvoiceAmount repository.
        /// </summary>
        private readonly IGetInvoiceAmountRepository repository;

        public class Annotation
        {
            public long TransactionMasterId { get; set; }
        }


        public GetInvoiceAmountController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();

            this.repository = new GetInvoiceAmountProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        public GetInvoiceAmountController(IGetInvoiceAmountRepository repository, string catalog, LoginView view)
        {
            this._LoginId = view.LoginId.ToLong();
            this._UserId = view.UserId.ToInt();
            this._OfficeId = view.OfficeId.ToInt();
            this._Catalog = catalog;

            this.repository = repository;
        }

        /// <summary>
        ///     Creates meta information of "get invoice amount" annotation.
        /// </summary>
        /// <returns>Returns the "get invoice amount" annotation meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("annotation")]
        [Route("~/api/transactions/procedures/get-invoice-amount/annotation")]
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
                                        new EntityColumn { ColumnName = "transaction_master_id_",  PropertyName = "TransactionMasterId",  DataType = "long",  DbDataType = "bigint",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 }
                                }
            };
        }


        /// <summary>
        ///     Creates meta information of "get invoice amount" entity.
        /// </summary>
        /// <returns>Returns the "get invoice amount" meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("meta")]
        [Route("~/api/transactions/procedures/get-invoice-amount/meta")]
        public EntityView GetEntityView()
        {
            if (this._LoginId == 0)
            {
                return new EntityView();
            }
            return new EntityView
            {
                Columns = new List<EntityColumn>()
                {
                }
            };
        }


        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/transactions/procedures/get-invoice-amount/execute")]
        public decimal Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.repository.TransactionMasterId = annotation.TransactionMasterId;


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