// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "transactions.get_salesperson_report(_office_id integer, _factor integer)" on the database.
    /// </summary>
    public class GetSalespersonReportProcedure : DbAccess, IGetSalespersonReportRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_salesperson_report";
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
        /// Maps to "_office_id" argument of the function "transactions.get_salesperson_report".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_factor" argument of the function "transactions.get_salesperson_report".
        /// </summary>
        public int Factor { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_salesperson_report(_office_id integer, _factor integer)" on the database.
        /// </summary>
        public GetSalespersonReportProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_salesperson_report(_office_id integer, _factor integer)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_salesperson_report".</param>
        /// <param name="factor">Enter argument value for "_factor" parameter of the function "transactions.get_salesperson_report".</param>
        public GetSalespersonReportProcedure(int officeId, int factor)
        {
            this.OfficeId = officeId;
            this.Factor = factor;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_salesperson_report".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetSalespersonReportResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetSalespersonReportProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_salesperson_report(@OfficeId, @Factor);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");
            query = query.ReplaceWholeWord("@Factor", "@1::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);
            parameters.Add(this.Factor);

            return Factory.Get<DbGetSalespersonReportResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}