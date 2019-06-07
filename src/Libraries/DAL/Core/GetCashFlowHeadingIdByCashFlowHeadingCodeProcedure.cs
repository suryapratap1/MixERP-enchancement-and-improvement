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
    /// Prepares, validates, and executes the function "core.get_cash_flow_heading_id_by_cash_flow_heading_code(_cash_flow_heading_code character varying)" on the database.
    /// </summary>
    public class GetCashFlowHeadingIdByCashFlowHeadingCodeProcedure : DbAccess, IGetCashFlowHeadingIdByCashFlowHeadingCodeRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_cash_flow_heading_id_by_cash_flow_heading_code";
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
        /// Maps to "_cash_flow_heading_code" argument of the function "core.get_cash_flow_heading_id_by_cash_flow_heading_code".
        /// </summary>
        public string CashFlowHeadingCode { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_cash_flow_heading_id_by_cash_flow_heading_code(_cash_flow_heading_code character varying)" on the database.
        /// </summary>
        public GetCashFlowHeadingIdByCashFlowHeadingCodeProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_cash_flow_heading_id_by_cash_flow_heading_code(_cash_flow_heading_code character varying)" on the database.
        /// </summary>
        /// <param name="cashFlowHeadingCode">Enter argument value for "_cash_flow_heading_code" parameter of the function "core.get_cash_flow_heading_id_by_cash_flow_heading_code".</param>
        public GetCashFlowHeadingIdByCashFlowHeadingCodeProcedure(string cashFlowHeadingCode)
        {
            this.CashFlowHeadingCode = cashFlowHeadingCode;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_cash_flow_heading_id_by_cash_flow_heading_code".
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
                    Log.Information("Access to the function \"GetCashFlowHeadingIdByCashFlowHeadingCodeProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_cash_flow_heading_id_by_cash_flow_heading_code(@CashFlowHeadingCode);";

            query = query.ReplaceWholeWord("@CashFlowHeadingCode", "@0::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.CashFlowHeadingCode);

            return Factory.Scalar<int>(this._Catalog, query, parameters.ToArray());
        }


    }
}