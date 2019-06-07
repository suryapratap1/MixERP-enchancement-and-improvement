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
    /// Prepares, validates, and executes the function "core.get_county_sales_tax_rate(_county_sales_tax_id integer)" on the database.
    /// </summary>
    public class GetCountySalesTaxRateProcedure : DbAccess, IGetCountySalesTaxRateRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_county_sales_tax_rate";
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
        /// Maps to "_county_sales_tax_id" argument of the function "core.get_county_sales_tax_rate".
        /// </summary>
        public int CountySalesTaxId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_county_sales_tax_rate(_county_sales_tax_id integer)" on the database.
        /// </summary>
        public GetCountySalesTaxRateProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_county_sales_tax_rate(_county_sales_tax_id integer)" on the database.
        /// </summary>
        /// <param name="countySalesTaxId">Enter argument value for "_county_sales_tax_id" parameter of the function "core.get_county_sales_tax_rate".</param>
        public GetCountySalesTaxRateProcedure(int countySalesTaxId)
        {
            this.CountySalesTaxId = countySalesTaxId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_county_sales_tax_rate".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public decimal Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetCountySalesTaxRateProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_county_sales_tax_rate(@CountySalesTaxId);";

            query = query.ReplaceWholeWord("@CountySalesTaxId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.CountySalesTaxId);

            return Factory.Get<decimal>(this._Catalog, query, parameters.ToArray()).FirstOrDefault();
        }


    }
}