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
    /// Prepares, validates, and executes the function "transactions.get_balance_sheet(_previous_period date, _current_period date, _user_id integer, _office_id integer, _factor integer)" on the database.
    /// </summary>
    public class GetBalanceSheetProcedure : DbAccess, IGetBalanceSheetRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_balance_sheet";
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
        /// Maps to "_previous_period" argument of the function "transactions.get_balance_sheet".
        /// </summary>
        public DateTime PreviousPeriod { get; set; }
        /// <summary>
        /// Maps to "_current_period" argument of the function "transactions.get_balance_sheet".
        /// </summary>
        public DateTime CurrentPeriod { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.get_balance_sheet".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_balance_sheet".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_factor" argument of the function "transactions.get_balance_sheet".
        /// </summary>
        public int Factor { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_balance_sheet(_previous_period date, _current_period date, _user_id integer, _office_id integer, _factor integer)" on the database.
        /// </summary>
        public GetBalanceSheetProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_balance_sheet(_previous_period date, _current_period date, _user_id integer, _office_id integer, _factor integer)" on the database.
        /// </summary>
        /// <param name="previousPeriod">Enter argument value for "_previous_period" parameter of the function "transactions.get_balance_sheet".</param>
        /// <param name="currentPeriod">Enter argument value for "_current_period" parameter of the function "transactions.get_balance_sheet".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_balance_sheet".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_balance_sheet".</param>
        /// <param name="factor">Enter argument value for "_factor" parameter of the function "transactions.get_balance_sheet".</param>
        public GetBalanceSheetProcedure(DateTime previousPeriod, DateTime currentPeriod, int userId, int officeId, int factor)
        {
            this.PreviousPeriod = previousPeriod;
            this.CurrentPeriod = currentPeriod;
            this.UserId = userId;
            this.OfficeId = officeId;
            this.Factor = factor;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_balance_sheet".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetBalanceSheetResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetBalanceSheetProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_balance_sheet(@PreviousPeriod, @CurrentPeriod, @UserId, @OfficeId, @Factor);";

            query = query.ReplaceWholeWord("@PreviousPeriod", "@0::date");
            query = query.ReplaceWholeWord("@CurrentPeriod", "@1::date");
            query = query.ReplaceWholeWord("@UserId", "@2::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@3::integer");
            query = query.ReplaceWholeWord("@Factor", "@4::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.PreviousPeriod);
            parameters.Add(this.CurrentPeriod);
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.Factor);

            return Factory.Get<DbGetBalanceSheetResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}