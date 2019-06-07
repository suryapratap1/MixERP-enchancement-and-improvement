// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.get_flag_type_id(user_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
    /// </summary>
    public class GetFlagTypeIdProcedure : DbAccess, IGetFlagTypeIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_flag_type_id";
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
        /// Maps to "user_id_" argument of the function "core.get_flag_type_id".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "resource_" argument of the function "core.get_flag_type_id".
        /// </summary>
        public string Resource { get; set; }
        /// <summary>
        /// Maps to "resource_key_" argument of the function "core.get_flag_type_id".
        /// </summary>
        public string ResourceKey { get; set; }
        /// <summary>
        /// Maps to "resource_id_" argument of the function "core.get_flag_type_id".
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_flag_type_id(user_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
        /// </summary>
        public GetFlagTypeIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_flag_type_id(user_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "user_id_" parameter of the function "core.get_flag_type_id".</param>
        /// <param name="resource">Enter argument value for "resource_" parameter of the function "core.get_flag_type_id".</param>
        /// <param name="resourceKey">Enter argument value for "resource_key_" parameter of the function "core.get_flag_type_id".</param>
        /// <param name="resourceId">Enter argument value for "resource_id_" parameter of the function "core.get_flag_type_id".</param>
        public GetFlagTypeIdProcedure(int userId, string resource, string resourceKey, string resourceId)
        {
            this.UserId = userId;
            this.Resource = resource;
            this.ResourceKey = resourceKey;
            this.ResourceId = resourceId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_flag_type_id".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public int Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetFlagTypeIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_flag_type_id(@UserId, @Resource, @ResourceKey, @ResourceId);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@Resource", "@1::text");
            query = query.ReplaceWholeWord("@ResourceKey", "@2::text");
            query = query.ReplaceWholeWord("@ResourceId", "@3::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.Resource);
            parameters.Add(this.ResourceKey);
            parameters.Add(this.ResourceId);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }


    }
}