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
    /// Prepares, validates, and executes the function "core.create_new_fiscal_year(_office_id integer, _user_id integer, _fiscal_year_code character varying, _fiscal_year_name character varying)" on the database.
    /// </summary>
    public class CreateNewFiscalYearProcedure : DbAccess, ICreateNewFiscalYearRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "create_new_fiscal_year";
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
        /// Maps to "_office_id" argument of the function "core.create_new_fiscal_year".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "core.create_new_fiscal_year".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_fiscal_year_code" argument of the function "core.create_new_fiscal_year".
        /// </summary>
        public string FiscalYearCode { get; set; }
        /// <summary>
        /// Maps to "_fiscal_year_name" argument of the function "core.create_new_fiscal_year".
        /// </summary>
        public string FiscalYearName { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_new_fiscal_year(_office_id integer, _user_id integer, _fiscal_year_code character varying, _fiscal_year_name character varying)" on the database.
        /// </summary>
        public CreateNewFiscalYearProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.create_new_fiscal_year(_office_id integer, _user_id integer, _fiscal_year_code character varying, _fiscal_year_name character varying)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "core.create_new_fiscal_year".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "core.create_new_fiscal_year".</param>
        /// <param name="fiscalYearCode">Enter argument value for "_fiscal_year_code" parameter of the function "core.create_new_fiscal_year".</param>
        /// <param name="fiscalYearName">Enter argument value for "_fiscal_year_name" parameter of the function "core.create_new_fiscal_year".</param>
        public CreateNewFiscalYearProcedure(int officeId, int userId, string fiscalYearCode, string fiscalYearName)
        {
            this.OfficeId = officeId;
            this.UserId = userId;
            this.FiscalYearCode = fiscalYearCode;
            this.FiscalYearName = fiscalYearName;
        }
        /// <summary>
        /// Prepares and executes the function "core.create_new_fiscal_year".
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
                    Log.Information("Access to the function \"CreateNewFiscalYearProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.create_new_fiscal_year(@OfficeId, @UserId, @FiscalYearCode, @FiscalYearName);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");
            query = query.ReplaceWholeWord("@UserId", "@1::integer");
            query = query.ReplaceWholeWord("@FiscalYearCode", "@2::character varying");
            query = query.ReplaceWholeWord("@FiscalYearName", "@3::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);
            parameters.Add(this.UserId);
            parameters.Add(this.FiscalYearCode);
            parameters.Add(this.FiscalYearName);

            Factory.NonQuery(this._Catalog, query, parameters.ToArray());
        }


    }
}