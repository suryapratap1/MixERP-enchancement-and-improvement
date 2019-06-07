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
    /// Prepares, validates, and executes the function "core.get_income_tax_provison_amount(_office_id integer, _profit numeric, _balance numeric)" on the database.
    /// </summary>
    public class GetIncomeTaxProvisonAmountProcedure : DbAccess, IGetIncomeTaxProvisonAmountRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_income_tax_provison_amount";
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
        /// Maps to "_office_id" argument of the function "core.get_income_tax_provison_amount".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_profit" argument of the function "core.get_income_tax_provison_amount".
        /// </summary>
        public decimal Profit { get; set; }
        /// <summary>
        /// Maps to "_balance" argument of the function "core.get_income_tax_provison_amount".
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_income_tax_provison_amount(_office_id integer, _profit numeric, _balance numeric)" on the database.
        /// </summary>
        public GetIncomeTaxProvisonAmountProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_income_tax_provison_amount(_office_id integer, _profit numeric, _balance numeric)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "core.get_income_tax_provison_amount".</param>
        /// <param name="profit">Enter argument value for "_profit" parameter of the function "core.get_income_tax_provison_amount".</param>
        /// <param name="balance">Enter argument value for "_balance" parameter of the function "core.get_income_tax_provison_amount".</param>
        public GetIncomeTaxProvisonAmountProcedure(int officeId, decimal profit, decimal balance)
        {
            this.OfficeId = officeId;
            this.Profit = profit;
            this.Balance = balance;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_income_tax_provison_amount".
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
                    Log.Information("Access to the function \"GetIncomeTaxProvisonAmountProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_income_tax_provison_amount(@OfficeId, @Profit, @Balance);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");
            query = query.ReplaceWholeWord("@Profit", "@1::numeric");
            query = query.ReplaceWholeWord("@Balance", "@2::numeric");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);
            parameters.Add(this.Profit);
            parameters.Add(this.Balance);

            return Factory.Scalar<decimal>(this._Catalog, query, parameters.ToArray());
        }


    }
}