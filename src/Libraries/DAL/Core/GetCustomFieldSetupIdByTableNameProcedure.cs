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
    /// Prepares, validates, and executes the function "core.get_custom_field_setup_id_by_table_name(_table_name character varying, _field_name character varying)" on the database.
    /// </summary>
    public class GetCustomFieldSetupIdByTableNameProcedure : DbAccess, IGetCustomFieldSetupIdByTableNameRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_custom_field_setup_id_by_table_name";
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
        /// Maps to "_table_name" argument of the function "core.get_custom_field_setup_id_by_table_name".
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// Maps to "_field_name" argument of the function "core.get_custom_field_setup_id_by_table_name".
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_custom_field_setup_id_by_table_name(_table_name character varying, _field_name character varying)" on the database.
        /// </summary>
        public GetCustomFieldSetupIdByTableNameProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_custom_field_setup_id_by_table_name(_table_name character varying, _field_name character varying)" on the database.
        /// </summary>
        /// <param name="tableName">Enter argument value for "_table_name" parameter of the function "core.get_custom_field_setup_id_by_table_name".</param>
        /// <param name="fieldName">Enter argument value for "_field_name" parameter of the function "core.get_custom_field_setup_id_by_table_name".</param>
        public GetCustomFieldSetupIdByTableNameProcedure(string tableName, string fieldName)
        {
            this.TableName = tableName;
            this.FieldName = fieldName;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_custom_field_setup_id_by_table_name".
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
                    Log.Information("Access to the function \"GetCustomFieldSetupIdByTableNameProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_custom_field_setup_id_by_table_name(@TableName, @FieldName);";

            query = query.ReplaceWholeWord("@TableName", "@0::character varying");
            query = query.ReplaceWholeWord("@FieldName", "@1::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.TableName);
            parameters.Add(this.FieldName);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }


    }
}