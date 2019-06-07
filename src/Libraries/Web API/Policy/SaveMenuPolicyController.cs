// ReSharper disable All
using MixERP.Net.Framework;
using MixERP.Net.Entities.Policy;
using MixERP.Net.Schemas.Policy.Data;
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
namespace MixERP.Net.Api.Policy
{
    /// <summary>
    /// Provides a direct HTTP access to execute the function SaveMenuPolicy.
    /// </summary>
    [RoutePrefix("api/v1.5/policy/procedures/save-menu-policy")]
    public class SaveMenuPolicyController : ApiController
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
        ///     The SaveMenuPolicy repository.
        /// </summary>
        private readonly ISaveMenuPolicyRepository repository;

        public class Annotation
        {
            public int UserId { get; set; }
            public int OfficeId { get; set; }
            public int[] MenuIds { get; set; }
        }


        public SaveMenuPolicyController()
        {
            this._LoginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            this._UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this._OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            this._Catalog = AppUsers.GetCurrentUserDB();

            this.repository = new SaveMenuPolicyProcedure
            {
                _Catalog = this._Catalog,
                _LoginId = this._LoginId,
                _UserId = this._UserId
            };
        }

        public SaveMenuPolicyController(ISaveMenuPolicyRepository repository, string catalog, LoginView view)
        {
            this._LoginId = view.LoginId.ToLong();
            this._UserId = view.UserId.ToInt();
            this._OfficeId = view.OfficeId.ToInt();
            this._Catalog = catalog;

            this.repository = repository;
        }

        /// <summary>
        ///     Creates meta information of "save menu policy" annotation.
        /// </summary>
        /// <returns>Returns the "save menu policy" annotation meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("annotation")]
        [Route("~/api/policy/procedures/save-menu-policy/annotation")]
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
                                        new EntityColumn { ColumnName = "_menu_ids",  PropertyName = "MenuIds",  DataType = "int",  DbDataType = "integer[]",  IsNullable = false,  IsPrimaryKey = false,  IsSerial = false,  Value = "",  MaxLength = 0 }
                                }
            };
        }


        /// <summary>
        ///     Creates meta information of "save menu policy" entity.
        /// </summary>
        /// <returns>Returns the "save menu policy" meta information to perform CRUD operation.</returns>
        [AcceptVerbs("GET", "HEAD")]
        [Route("meta")]
        [Route("~/api/policy/procedures/save-menu-policy/meta")]
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
        [Route("~/api/policy/procedures/save-menu-policy/execute")]
        public void Execute([FromBody] Annotation annotation)
        {
            try
            {
                this.repository.UserId = annotation.UserId;
                this.repository.OfficeId = annotation.OfficeId;
                this.repository.MenuIds = annotation.MenuIds;


                this.repository.Execute();
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