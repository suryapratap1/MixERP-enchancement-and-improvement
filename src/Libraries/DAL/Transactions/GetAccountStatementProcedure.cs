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
    /// Prepares, validates, and executes the function "transactions.get_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _account_id bigint, _office_id integer)" on the database.
    /// </summary>
    public class GetAccountStatementProcedure : DbAccess, IGetAccountStatementRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_account_statement";
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
        /// Maps to "_value_date_from" argument of the function "transactions.get_account_statement".
        /// </summary>
        public DateTime ValueDateFrom { get; set; }
        /// <summary>
        /// Maps to "_value_date_to" argument of the function "transactions.get_account_statement".
        /// </summary>
        public DateTime ValueDateTo { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.get_account_statement".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_account_id" argument of the function "transactions.get_account_statement".
        /// </summary>
        public long AccountId { get; set; }
        /// <summary>
        /// Maps to "_office_id" argument of the function "transactions.get_account_statement".
        /// </summary>
        public int OfficeId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _account_id bigint, _office_id integer)" on the database.
        /// </summary>
        public GetAccountStatementProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _account_id bigint, _office_id integer)" on the database.
        /// </summary>
        /// <param name="valueDateFrom">Enter argument value for "_value_date_from" parameter of the function "transactions.get_account_statement".</param>
        /// <param name="valueDateTo">Enter argument value for "_value_date_to" parameter of the function "transactions.get_account_statement".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_account_statement".</param>
        /// <param name="accountId">Enter argument value for "_account_id" parameter of the function "transactions.get_account_statement".</param>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.get_account_statement".</param>
        public GetAccountStatementProcedure(DateTime valueDateFrom, DateTime valueDateTo, int userId, long accountId, int officeId)
        {
            this.ValueDateFrom = valueDateFrom;
            this.ValueDateTo = valueDateTo;
            this.UserId = userId;
            this.AccountId = accountId;
            this.OfficeId = officeId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_account_statement".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetAccountStatementResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetAccountStatementProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_account_statement(@ValueDateFrom, @ValueDateTo, @UserId, @AccountId, @OfficeId);";

            query = query.ReplaceWholeWord("@ValueDateFrom", "@0::date");
            query = query.ReplaceWholeWord("@ValueDateTo", "@1::date");
            query = query.ReplaceWholeWord("@UserId", "@2::integer");
            query = query.ReplaceWholeWord("@AccountId", "@3::bigint");
            query = query.ReplaceWholeWord("@OfficeId", "@4::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.ValueDateFrom);
            parameters.Add(this.ValueDateTo);
            parameters.Add(this.UserId);
            parameters.Add(this.AccountId);
            parameters.Add(this.OfficeId);

            return Factory.Get<DbGetAccountStatementResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}