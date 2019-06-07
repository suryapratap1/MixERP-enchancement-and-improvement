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
    /// Provides a direct HTTP access to execute the function PostStockAdjustment.
    /// </summary>
    [RoutePrefix("api/v1.5/transactions/procedures/post-stock-adjustment")]
    public class PostStockAdjustmentController : ApiController
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
        ///     The PostStockAdjustment repository.
        /// </summary>
        private readonly IPostStockAdjustmentRepository repository;

        public class Annotation
        {
            public int OfficeId { get; set; }
            public int UserId { get; set; }
            public long LoginId { get; set; }
            public DateTime ValueDate { get; set; }
            public string ReferenceNumber { get; set; }
            public string StatementReference { get; set; }
            public MixERP.Net.Entities.Transactions.StockAdjustmentType[] Details { get; set; }
        }


        public PostStockAdjustmentController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();

            this.repository = new PostStockAdjustmentProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        public PostStockAdjustmentController(IPostStockAdjustmentRepository repository, string catalog, LoginView view)
        {
            this._LoginId = view.LoginId.ToLong();
            this._UserId = view.UserId.ToInt();
            this._OfficeId = view.OfficeId.ToInt();
            this._Catalog = catalog;

            this.repository = repository;
        }

        /// <summary>
        ///     Creates meta information of "post stock adjustment" annotation.
        /// </summary>
        /// <returns>Returns the "post stock adjustment" annotation meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("annotation")]
        [Route("~/api/transactions/procedures/post-stock-adjustment/annotation")]
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
                                        new EntityColumn { ColumnName = "_office_id",  PropertyName = "OfficeId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_user_id",  PropertyName = "UserId",  DataType = "int",  DbDataType = "integer",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_login_id",  PropertyName = "LoginId",  DataType = "long",  DbDataType = "bigint",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_value_date",  PropertyName = "ValueDate",  DataType = "DateTime",  DbDataType = "date",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_reference_number",  PropertyName = "ReferenceNumber",  DataType = "string",  DbDataType = "character varying",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_statement_reference",  PropertyName = "StatementReference",  DataType = "string",  DbDataType = "text",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "_details",  PropertyName = "Details",  DataType = "MixERP.Net.Entities.Transactions.StockAdjustmentType",  DbDataType = "transactions.stock_adjustment_type[]",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 }
                                }
            };
        }




        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/transactions/procedures/post-stock-adjustment/execute")]
        public long Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.repository.OfficeId = annotation.OfficeId;
                this.repository.UserId = annotation.UserId;
                this.repository.LoginId = annotation.LoginId;
                this.repository.ValueDate = annotation.ValueDate;
                this.repository.ReferenceNumber = annotation.ReferenceNumber;
                this.repository.StatementReference = annotation.StatementReference;
                this.repository.Details = annotation.Details;


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