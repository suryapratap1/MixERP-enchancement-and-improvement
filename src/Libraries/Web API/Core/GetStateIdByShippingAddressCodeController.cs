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
    /// Provides a direct HTTP access to execute the function GetStateIdByShippingAddressCode.
    /// </summary>
    [RoutePrefix("api/v1.5/core/procedures/get-state-id-by-shipping-address-code")]
    public class GetStateIdByShippingAddressCodeController : ApiController
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
        ///     The GetStateIdByShippingAddressCode repository.
        /// </summary>
        private readonly IGetStateIdByShippingAddressCodeRepository repository;

        public class Annotation
        {
            public string PgArg0 { get; set; }
            public long PgArg1 { get; set; }
        }


        public GetStateIdByShippingAddressCodeController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();

            this.repository = new GetStateIdByShippingAddressCodeProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        public GetStateIdByShippingAddressCodeController(IGetStateIdByShippingAddressCodeRepository repository, string catalog, LoginView view)
        {
            this._LoginId = view.LoginId.ToLong();
            this._UserId = view.UserId.ToInt();
            this._OfficeId = view.OfficeId.ToInt();
            this._Catalog = catalog;

            this.repository = repository;
        }

        /// <summary>
        ///     Creates meta information of "get state id by shipping address code" annotation.
        /// </summary>
        /// <returns>Returns the "get state id by shipping address code" annotation meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("annotation")]
        [Route("~/api/core/procedures/get-state-id-by-shipping-address-code/annotation")]
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
                                        new EntityColumn { ColumnName = "text",  PropertyName = "Text",  DataType = "",  DbDataType = "",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 },
                                        new EntityColumn { ColumnName = "bigint",  PropertyName = "Bigint",  DataType = "",  DbDataType = "",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 }
                                }
            };
        }




        [AcceptVerbs("POST")]
        [Route("execute")]
        [Route("~/api/core/procedures/get-state-id-by-shipping-address-code/execute")]
        public int Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.repository.PgArg0 = annotation.PgArg0;
                this.repository.PgArg1 = annotation.PgArg1;


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