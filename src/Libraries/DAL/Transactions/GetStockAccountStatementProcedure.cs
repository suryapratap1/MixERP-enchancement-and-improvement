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
    /// Prepares, validates, and executes the function "transactions.get_stock_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _item_id integer, _store_id integer)" on the database.
    /// </summary>
    public class GetStockAccountStatementProcedure : DbAccess, IGetStockAccountStatementRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_stock_account_statement";
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
        /// Maps to "_value_date_from" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public DateTime ValueDateFrom { get; set; }
        /// <summary>
        /// Maps to "_value_date_to" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public DateTime ValueDateTo { get; set; }
        /// <summary>
        /// Maps to "_user_id" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Maps to "_item_id" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public int ItemId { get; set; }
        /// <summary>
        /// Maps to "_store_id" argument of the function "transactions.get_stock_account_statement".
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_stock_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _item_id integer, _store_id integer)" on the database.
        /// </summary>
        public GetStockAccountStatementProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_stock_account_statement(_value_date_from date, _value_date_to date, _user_id integer, _item_id integer, _store_id integer)" on the database.
        /// </summary>
        /// <param name="valueDateFrom">Enter argument value for "_value_date_from" parameter of the function "transactions.get_stock_account_statement".</param>
        /// <param name="valueDateTo">Enter argument value for "_value_date_to" parameter of the function "transactions.get_stock_account_statement".</param>
        /// <param name="userId">Enter argument value for "_user_id" parameter of the function "transactions.get_stock_account_statement".</param>
        /// <param name="itemId">Enter argument value for "_item_id" parameter of the function "transactions.get_stock_account_statement".</param>
        /// <param name="storeId">Enter argument value for "_store_id" parameter of the function "transactions.get_stock_account_statement".</param>
        public GetStockAccountStatementProcedure(DateTime valueDateFrom, DateTime valueDateTo, int userId, int itemId, int storeId)
        {
            this.ValueDateFrom = valueDateFrom;
            this.ValueDateTo = valueDateTo;
            this.UserId = userId;
            this.ItemId = itemId;
            this.StoreId = storeId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_stock_account_statement".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public IEnumerable<DbGetStockAccountStatementResult> Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetStockAccountStatementProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_stock_account_statement(@ValueDateFrom, @ValueDateTo, @UserId, @ItemId, @StoreId);";

            query = query.ReplaceWholeWord("@ValueDateFrom", "@0::date");
            query = query.ReplaceWholeWord("@ValueDateTo", "@1::date");
            query = query.ReplaceWholeWord("@UserId", "@2::integer");
            query = query.ReplaceWholeWord("@ItemId", "@3::integer");
            query = query.ReplaceWholeWord("@StoreId", "@4::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.ValueDateFrom);
            parameters.Add(this.ValueDateTo);
            parameters.Add(this.UserId);
            parameters.Add(this.ItemId);
            parameters.Add(this.StoreId);

            return Factory.Get<DbGetStockAccountStatementResult>(this._Catalog, query, parameters.ToArray());
        }


    }
}