// ReSharper disable All
using MixERP.Net.Framework;
using MixERP.Net.Entities.Office;
using MixERP.Net.Schemas.Office.Data;
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
namespace MixERP.Net.Api.Office
{
    /// <summary>
    /// Provides a direct HTTP access to execute the function GetCashRepositoryIdByCashRepositoryName.
    /// </summary>
    [RoutePrefix("api/v1.5/office/procedures/get-cash-repository-id-by-cash-repository-name")]
    public class GetCashRepositoryIdByCashRepositoryNameController : ApiController
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
        ///     The GetCashRepositoryIdByCashRepositoryName repository.
        /// </summary>
        private readonly IGetCashRepositoryIdByCashRepositoryNameRepository repository;

        public class Annotation
        {
            public string CashRepositoryName { get; set; }
        }


        public GetCashRepositoryIdByCashRepositoryNameController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();

            this.repository = new GetCashRepositoryIdByCashRepositoryNameProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        public GetCashRepositoryIdByCashRepositoryNameController(IGetCashRepositoryIdByCashRepositoryNameRepository repository, string catalog, LoginView view)
        {
            this._LoginId = view.LoginId.ToLong();
            this._UserId = view.UserId.ToInt();
            this._OfficeId = view.OfficeId.ToInt();
            this._Catalog = catalog;

            this.repository = repository;
        }

        /// <summary>
        ///     Creates meta information of "get cash repository id by cash repository name" annotation.
        /// </summary>
        /// <returns>Returns the "get cash repository id by cash repository name" annotation meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("annotation")]
        [Route("~/api/office/procedures/get-cash-repository-id-by-cash-repository-name/annotation")]
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
                                        new EntityColumn { ColumnName = "_cash_repository_name",  PropertyName = "CashRepositoryName",  DataType = "string",  DbDataType = "text",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 }
                                }
            };
        }




        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/office/procedures/get-cash-repository-id-by-cash-repository-name/execute")]
        public int Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.repository.CashRepositoryName = annotation.CashRepositoryName;


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