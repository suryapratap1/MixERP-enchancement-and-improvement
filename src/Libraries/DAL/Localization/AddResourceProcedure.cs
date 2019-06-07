// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Localization;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Localization.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "localization.add_resource(resource_class text, key text, value text)" on the database.
    /// </summary>
    public class AddResourceProcedure : DbAccess, IAddResourceRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "localization";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "add_resource";
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
        /// Maps to "resource_class" argument of the function "localization.add_resource".
        /// </summary>
        public string ResourceClass { get; set; }
        /// <summary>
        /// Maps to "key" argument of the function "localization.add_resource".
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Maps to "value" argument of the function "localization.add_resource".
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.add_resource(resource_class text, key text, value text)" on the database.
        /// </summary>
        public AddResourceProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.add_resource(resource_class text, key text, value text)" on the database.
        /// </summary>
        /// <param name="resourceClass">Enter argument value for "resource_class" parameter of the function "localization.add_resource".</param>
        /// <param name="key">Enter argument value for "key" parameter of the function "localization.add_resource".</param>
        /// <param name="value">Enter argument value for "value" parameter of the function "localization.add_resource".</param>
        public AddResourceProcedure(string resourceClass, string key, string value)
        {
            this.ResourceClass = resourceClass;
            this.Key = key;
            this.Value = value;
        }
        /// <summary>
        /// Prepares and executes the function "localization.add_resource".
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
                    Log.Information("Access to the function \"AddResourceProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM localization.add_resource(@ResourceClass, @Key, @Value);";

            query = query.ReplaceWholeWord("@ResourceClass", "@0::text");
            query = query.ReplaceWholeWord("@Key", "@1::text");
            query = query.ReplaceWholeWord("@Value", "@2::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.ResourceClass);
            parameters.Add(this.Key);
            parameters.Add(this.Value);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}