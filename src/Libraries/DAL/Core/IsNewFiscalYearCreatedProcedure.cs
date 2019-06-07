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
    /// Prepares, validates, and executes the function "core.is_new_fiscal_year_created(_office_id integer)" on the database.
    /// </summary>
    public class IsNewFiscalYearCreatedProcedure : DbAccess, IIsNewFiscalYearCreatedRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "is_new_fiscal_year_created";
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
        /// Maps to "_office_id" argument of the function "core.is_new_fiscal_year_created".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.is_new_fiscal_year_created(_office_id integer)" on the database.
        /// </summary>
        public IsNewFiscalYearCreatedProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.is_new_fiscal_year_created(_office_id integer)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "core.is_new_fiscal_year_created".</param>
        public IsNewFiscalYearCreatedProcedure(int officeId)
        {
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "core.is_new_fiscal_year_created".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public bool Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"IsNewFiscalYearCreatedProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.is_new_fiscal_year_created(@OfficeId);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}