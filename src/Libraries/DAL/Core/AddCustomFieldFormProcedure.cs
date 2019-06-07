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
    /// Prepares, validates, and executes the function "core.add_custom_field_form(_form_name character varying, _table_name character varying, _key_name character varying)" on the database.
    /// </summary>
    public class AddCustomFieldFormProcedure : DbAccess, IAddCustomFieldFormRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "add_custom_field_form";
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
        /// Maps to "_form_name" argument of the function "core.add_custom_field_form".
        /// </summary>
        public string FormName { get; set; }
        /// <summary>
        /// Maps to "_table_name" argument of the function "core.add_custom_field_form".
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// Maps to "_key_name" argument of the function "core.add_custom_field_form".
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.add_custom_field_form(_form_name character varying, _table_name character varying, _key_name character varying)" on the database.
        /// </summary>
        public AddCustomFieldFormProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.add_custom_field_form(_form_name character varying, _table_name character varying, _key_name character varying)" on the database.
        /// </summary>
        /// <param name="formName">Enter argument value for "_form_name" parameter of the function "core.add_custom_field_form".</param>
        /// <param name="tableName">Enter argument value for "_table_name" parameter of the function "core.add_custom_field_form".</param>
        /// <param name="keyName">Enter argument value for "_key_name" parameter of the function "core.add_custom_field_form".</param>
        public AddCustomFieldFormProcedure(string formName, string tableName, string keyName)
        {
            this.FormName = formName;
            this.TableName = tableName;
            this.KeyName = keyName;
        }
        /// <summary>
        /// Prepares and executes the function "core.add_custom_field_form".
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
                    Log.Information("Access to the function \"AddCustomFieldFormProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.add_custom_field_form(@FormName, @TableName, @KeyName);";

            query = query.ReplaceWholeWord("@FormName", "@0::character varying");
            query = query.ReplaceWholeWord("@TableName", "@1::character varying");
            query = query.ReplaceWholeWord("@KeyName", "@2::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.FormName);
            parameters.Add(this.TableName);
            parameters.Add(this.KeyName);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}