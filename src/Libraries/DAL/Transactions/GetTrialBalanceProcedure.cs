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
    /// Prepares, validates, and executes the function "transactions.get_trial_balance(_date_from date, _date_to date, _user_id integer, _office_id integer, _compact boolean, _factor numeric, _change_side_when_negative boolean, _include_zero_balance_accounts boolean)" on the database.
    /// </summary>
    public class GetTrialBalanceProcedure : DbAccess, IGetTrialBalanceRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_trial_balance";
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
        /// Maps to "_date_from" argument of the function "transactions.get_trial_balance".
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Maps to "_date_to" argument of the function "transactions.get_trial_balance".
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.get_trial_balance".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_trial_balance".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_compact" argument of the function "transactions.get_trial_balance".
        /// </summary>
        public bool Compact { get; set; }
        /// <summary>
        /// Maps to "_factor" argument of the function "transactions.get_trial_balance".
        /// </summary>
        public decimal Factor { get; set; }
        /// <summary>
        /// Maps to "_change_side_when_negative" argument of the function "transactions.get_trial_balance".
        /// </summary>
        public bool ChangeSideWhenNegative { get; set; }
        /// <summary>
        /// Maps to "_include_zero_balance_accounts" argument of the function "transactions.get_trial_balance".
        /// </summary>
        public bool IncludeZeroBalanceAccounts { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_trial_balance(_date_from date, _date_to date, _user_id integer, _office_id integer, _compact boolean, _factor numeric, _change_side_when_negative boolean, _include_zero_balance_accounts boolean)" on the database.
        /// </summary>
        public GetTrialBalanceProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_trial_balance(_date_from date, _date_to date, _user_id integer, _office_id integer, _compact boolean, _factor numeric, _change_side_when_negative boolean, _include_zero_balance_accounts boolean)" on the database.
        /// </summary>
        /// <param name="dateFrom">Enter argument value for "_date_from" parameter of the function "transactions.get_trial_balance".</param>
        /// <param name="dateTo">Enter argument value for "_date_to" parameter of the function "transactions.get_trial_balance".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_trial_balance".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_trial_balance".</param>
        /// <param name="compact">Enter argument value for "_compact" parameter of the function "transactions.get_trial_balance".</param>
        /// <param name="factor">Enter argument value for "_factor" parameter of the function "transactions.get_trial_balance".</param>
        /// <param name="changeSideWhenNegative">Enter argument value for "_change_side_when_negative" parameter of the function "transactions.get_trial_balance".</param>
        /// <param name="includeZeroBalanceAccounts">Enter argument value for "_include_zero_balance_accounts" parameter of the function "transactions.get_trial_balance".</param>
        public GetTrialBalanceProcedure(DateTime dateFrom, DateTime dateTo, int userId, int officeId, bool compact, decimal factor, bool changeSideWhenNegative, bool includeZeroBalanceAccounts)
        {
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.UserId = userId;
            this.OfficeId = officeId;
            this.Compact = compact;
            this.Factor = factor;
            this.ChangeSideWhenNegative = changeSideWhenNegative;
            this.IncludeZeroBalanceAccounts = includeZeroBalanceAccounts;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_trial_balance".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetTrialBalanceResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetTrialBalanceProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_trial_balance(@DateFrom, @DateTo, @UserId, @OfficeId, @Compact, @Factor, @ChangeSideWhenNegative, @IncludeZeroBalanceAccounts);";

            query = query.ReplaceWholeWord("@DateFrom", "@0::date");
            query = query.ReplaceWholeWord("@DateTo", "@1::date");
            query = query.ReplaceWholeWord("@UserId", "@2::integer");
            query = query.ReplaceWholeWord("@OfficeId", "@3::integer");
            query = query.ReplaceWholeWord("@Compact", "@4::boolean");
            query = query.ReplaceWholeWord("@Factor", "@5::numeric");
            query = query.ReplaceWholeWord("@ChangeSideWhenNegative", "@6::boolean");
            query = query.ReplaceWholeWord("@IncludeZeroBalanceAccounts", "@7::boolean");


            List<object> parameters = new List<object>();
            parameters.Add(this.DateFrom);
            parameters.Add(this.DateTo);
            parameters.Add(this.UserId);
            parameters.Add(this.OfficeId);
            parameters.Add(this.Compact);
            parameters.Add(this.Factor);
            parameters.Add(this.ChangeSideWhenNegative);
            parameters.Add(this.IncludeZeroBalanceAccounts);

            return Factory.Get<DbGetTrialBalanceResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}