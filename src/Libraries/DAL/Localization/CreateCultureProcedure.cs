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
    /// Prepares, validates, and executes the function "localization.create_culture(_culture_code text, _culture_name text)" on the database.
    /// </summary>
    public class CreateCultureProcedure : DbAccess, ICreateCultureRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "localization";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_culture";
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
        /// Maps to "_culture_code" argument of the function "localization.create_culture".
        /// </summary>
        public string CultureCode { get; set; }
        /// <summary>
        /// Maps to "_culture_name" argument of the function "localization.create_culture".
        /// </summary>
        public string CultureName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.create_culture(_culture_code text, _culture_name text)" on the database.
        /// </summary>
        public CreateCultureProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "localization.create_culture(_culture_code text, _culture_name text)" on the database.
        /// </summary>
        /// <param name="cultureCode">Enter argument value for "_culture_code" parameter of the function "localization.create_culture".</param>
        /// <param name="cultureName">Enter argument value for "_culture_name" parameter of the function "localization.create_culture".</param>
        public CreateCultureProcedure(string cultureCode, string cultureName)
        {
            this.CultureCode = cultureCode;
            this.CultureName = cultureName;
        }
        /// <summary>
        /// Prepares and executes the function "localization.create_culture".
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
                    Log.Information("Access to the function \"CreateCultureProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM localization.create_culture(@CultureCode, @CultureName);";

            query = query.ReplaceWholeWord("@CultureCode", "@0::text");
            query = query.ReplaceWholeWord("@CultureName", "@1::text");


            List<object> parameters = new List<object>();
            parameters.Add(this.CultureCode);
            parameters.Add(this.CultureName);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}