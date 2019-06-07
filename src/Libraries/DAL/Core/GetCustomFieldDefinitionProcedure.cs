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
    /// Prepares, validates, and executes the function "core.get_custom_field_definition(_table_name text, _resource_id text)" on the database.
    /// </summary>
    public class GetCustomFieldDefinitionProcedure : DbAccess, IGetCustomFieldDefinitionRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_custom_field_definition";
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
        /// Maps to "_table_name" argument of the function "core.get_custom_field_definition".
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// Maps to "_resource_id" argument of the function "core.get_custom_field_definition".
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_custom_field_definition(_table_name text, _resource_id text)" on the database.
        /// </summary>
        public GetCustomFieldDefinitionProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_custom_field_definition(_table_name text, _resource_id text)" on the database.
        /// </summary>
        /// <param name="tableName">Enter argument value for "_table_name" parameter of the function "core.get_custom_field_definition".</param>
        /// <param name="resourceId">Enter argument value for "_resource_id" parameter of the function "core.get_custom_field_definition".</param>
        public GetCustomFieldDefinitionProcedure(string tableName, string resourceId)
        {
            this.TableName = tableName;
            this.ResourceId = resourceId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_custom_field_definition".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetCustomFieldDefinitionResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetCustomFieldDefinitionProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_custom_field_definition(@TableName, @ResourceId);";

            query = query.ReplaceWholeWord("@TableName", "@0::text");
            query = query.ReplaceWholeWord("@ResourceId", "@1::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.TableName);
            parameters.Add(this.ResourceId);

            return Factory.Get<DbGetCustomFieldDefinitionResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}