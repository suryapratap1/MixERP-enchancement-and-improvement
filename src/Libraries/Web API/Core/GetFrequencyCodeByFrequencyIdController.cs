// ReSharper disable All
using MixERP.Net.Framework;
using MixERP.Net.Entities.Core;
using MixERP.Net.Schemas.Core.Data;
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
namespace MixERP.Net.Api.Core
{
    /// <summary>
    /// Provides a direct HTTP access to execute the function GetFrequencyCodeByFrequencyId.
    /// </summary>
    [RoutePrefix("api/v1.5/core/procedures/get-frequency-code-by-frequency-id")]
    public class GetFrequencyCodeByFrequencyIdController : ApiController
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
        ///     The GetFrequencyCodeByFrequencyId repository.
        /// </summary>
        private readonly IGetFrequencyCodeByFrequencyIdRepository repository;

        public class Annotation
        {
            public int PgArg0 { get; set; }
        }


        public GetFrequencyCodeByFrequencyIdController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();

            this.repository = new GetFrequencyCodeByFrequencyIdProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        public GetFrequencyCodeByFrequencyIdController(IGetFrequencyCodeByFrequencyIdRepository repository, string catalog, LoginView view)
        {
            this._LoginId = view.LoginId.ToLong();
            this._UserId = view.UserId.ToInt();
            this._OfficeId = view.OfficeId.ToInt();
            this._Catalog = catalog;

            this.repository = repository;
        }

        /// <summary>
        ///     Creates meta information of "get frequency code by frequency id" annotation.
        /// </summary>
        /// <returns>Returns the "get frequency code by frequency id" annotation meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("annotation")]
        [Route("~/api/core/procedures/get-frequency-code-by-frequency-id/annotation")]
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
                                        new EntityColumn { ColumnName = "integer",  PropertyName = "Integer",  DataType = "",  DbDataType = "",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 }
                                }
            };
        }




        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/core/procedures/get-frequency-code-by-frequency-id/execute")]
        public string Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.repository.PgArg0 = annotation.PgArg0;


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