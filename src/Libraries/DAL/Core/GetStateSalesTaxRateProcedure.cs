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
    /// Prepares, validates, and executes the function "core.get_state_sales_tax_rate(_state_sales_tax_id integer)" on the database.
    /// </summary>
    public class GetStateSalesTaxRateProcedure : DbAccess, IGetStateSalesTaxRateRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_state_sales_tax_rate";
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
        /// Maps to "_state_sales_tax_id" argument of the function "core.get_state_sales_tax_rate".
        /// </summary>
        public int StateSalesTaxId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_state_sales_tax_rate(_state_sales_tax_id integer)" on the database.
        /// </summary>
        public GetStateSalesTaxRateProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_state_sales_tax_rate(_state_sales_tax_id integer)" on the database.
        /// </summary>
        /// <param name="stateSalesTaxId">Enter argument value for "_state_sales_tax_id" parameter of the function "core.get_state_sales_tax_rate".</param>
        public GetStateSalesTaxRateProcedure(int stateSalesTaxId)
        {
            this.StateSalesTaxId = stateSalesTaxId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_state_sales_tax_rate".
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
                    Log.Information("Access to the function \"GetStateSalesTaxRateProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_state_sales_tax_rate(@StateSalesTaxId);";

            query = query.ReplaceWholeWord("@StateSalesTaxId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.StateSalesTaxId);

            return Factory.Get<decimal>(this._Catalog, query, parameters.ToArray()).FirstOrDefault();
        }


    }
}