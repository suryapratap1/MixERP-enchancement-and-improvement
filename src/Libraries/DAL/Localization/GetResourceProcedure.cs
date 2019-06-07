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
    /// Prepares, validates, and executes the function "localization.get_resource(_culture_code text, _resource_class text, _key text)" on the database.
    /// </summary>
    public class GetResourceProcedure : DbAccess, IGetResourceRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "localization";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_resource";
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
        /// Maps to "_culture_code" argument of the function "localization.get_resource".
        /// </summary>
        public string CultureCode { get; set; }
        /// <summary>
        /// Maps to "_resource_class" argument of the function "localization.get_resource".
        /// </summary>
        public string ResourceClass { get; set; }
        /// <summary>
        /// Maps to "_key" argument of the function "localization.get_resource".
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.get_resource(_culture_code text, _resource_class text, _key text)" on the database.
        /// </summary>
        public GetResourceProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.get_resource(_culture_code text, _resource_class text, _key text)" on the database.
        /// </summary>
        /// <param name="cultureCode">Enter argument value for "_culture_code" parameter of the function "localization.get_resource".</param>
        /// <param name="resourceClass">Enter argument value for "_resource_class" parameter of the function "localization.get_resource".</param>
        /// <param name="key">Enter argument value for "_key" parameter of the function "localization.get_resource".</param>
        public GetResourceProcedure(string cultureCode, string resourceClass, string key)
        {
            this.CultureCode = cultureCode;
            this.ResourceClass = resourceClass;
            this.Key = key;
        }
        /// <summary>
        /// Prepares and executes the function "localization.get_resource".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public string Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetResourceProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM localization.get_resource(@CultureCode, @ResourceClass, @Key);";

            query = query.ReplaceWholeWord("@CultureCode", "@0::text");
            query = query.ReplaceWholeWord("@ResourceClass", "@1::text");
            query = query.ReplaceWholeWord("@Key", "@2::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.CultureCode);
            parameters.Add(this.ResourceClass);
            parameters.Add(this.Key);

            return Factory.Scalar<string>(this._Catalog, query, parameters.ToArray());
        }


    }
}