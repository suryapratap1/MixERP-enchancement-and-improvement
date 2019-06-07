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
    /// Prepares, validates, and executes the function "core.create_flag(user_id_ integer, flag_type_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
    /// </summary>
    public class CreateFlagProcedure : DbAccess, ICreateFlagRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_flag";
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
        /// Maps to "user_id_" argument of the function "core.create_flag".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "flag_type_id_" argument of the function "core.create_flag".
        /// </summary>
        public int FlagTypeId { get; set; }
        /// <summary>
        /// Maps to "resource_" argument of the function "core.create_flag".
        /// </summary>
        public string Resource { get; set; }
        /// <summary>
        /// Maps to "resource_key_" argument of the function "core.create_flag".
        /// </summary>
        public string ResourceKey { get; set; }
        /// <summary>
        /// Maps to "resource_id_" argument of the function "core.create_flag".
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_flag(user_id_ integer, flag_type_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
        /// </summary>
        public CreateFlagProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_flag(user_id_ integer, flag_type_id_ integer, resource_ text, resource_key_ text, resource_id_ text)" on the database.
        /// </summary>
        /// <param name="userId">Enter argument value for "user_id_" parameter of the function "core.create_flag".</param>
        /// <param name="flagTypeId">Enter argument value for "flag_type_id_" parameter of the function "core.create_flag".</param>
        /// <param name="resource">Enter argument value for "resource_" parameter of the function "core.create_flag".</param>
        /// <param name="resourceKey">Enter argument value for "resource_key_" parameter of the function "core.create_flag".</param>
        /// <param name="resourceId">Enter argument value for "resource_id_" parameter of the function "core.create_flag".</param>
        public CreateFlagProcedure(int userId, int flagTypeId, string resource, string resourceKey, string resourceId)
        {
            this.UserId = userId;
            this.FlagTypeId = flagTypeId;
            this.Resource = resource;
            this.ResourceKey = resourceKey;
            this.ResourceId = resourceId;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_flag".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public void Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"CreateFlagProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.create_flag(@UserId, @FlagTypeId, @Resource, @ResourceKey, @ResourceId);";

            query = query.ReplaceWholeWord("@UserId", "@0::integer");
            query = query.ReplaceWholeWord("@FlagTypeId", "@1::integer");
            query = query.ReplaceWholeWord("@Resource", "@2::text");
            query = query.ReplaceWholeWord("@ResourceKey", "@3::text");
            query = query.ReplaceWholeWord("@ResourceId", "@4::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.UserId);
            parameters.Add(this.FlagTypeId);
            parameters.Add(this.Resource);
            parameters.Add(this.ResourceKey);
            parameters.Add(this.ResourceId);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}