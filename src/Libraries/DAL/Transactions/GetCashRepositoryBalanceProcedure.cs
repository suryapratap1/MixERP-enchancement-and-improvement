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
    /// Prepares, validates, and executes the function "transactions.get_cash_repository_balance(_cash_repository_id integer, _currency_code character varying)" on the database.
    /// </summary>
    public class GetCashRepositoryBalanceProcedure : DbAccess, IGetCashRepositoryBalanceRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_cash_repository_balance";
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
        /// Maps to "_cash_repository_id" argument of the function "transactions.get_cash_repository_balance".
        /// </summary>
        public int CashRepositoryId { get; set; }
        /// <summary>
        /// Maps to "_currency_code" argument of the function "transactions.get_cash_repository_balance".
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_cash_repository_balance(_cash_repository_id integer, _currency_code character varying)" on the database.
        /// </summary>
        public GetCashRepositoryBalanceProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_cash_repository_balance(_cash_repository_id integer, _currency_code character varying)" on the database.
        /// </summary>
        /// <param name="cashRepositoryId">Enter argument value for "_cash_repository_id" parameter of the function "transactions.get_cash_repository_balance".</param>
        /// <param name="currencyCode">Enter argument value for "_currency_code" parameter of the function "transactions.get_cash_repository_balance".</param>
        public GetCashRepositoryBalanceProcedure(int cashRepositoryId, string currencyCode)
        {
            this.CashRepositoryId = cashRepositoryId;
            this.CurrencyCode = currencyCode;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_cash_repository_balance".
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
                    Log.Information("Access to the function \"GetCashRepositoryBalanceProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_cash_repository_balance(@CashRepositoryId, @CurrencyCode);";

            query = query.ReplaceWholeWord("@CashRepositoryId", "@0::integer");
            query = query.ReplaceWholeWord("@CurrencyCode", "@1::character varying");


            List<object> parameters = new List<object>();
            parameters.Add(this.CashRepositoryId);
            parameters.Add(this.CurrencyCode);

            return Factory.Get<decimal>(this._Catalog, query, parameters.ToArray()).FirstOrDefault();
        }


    }
}