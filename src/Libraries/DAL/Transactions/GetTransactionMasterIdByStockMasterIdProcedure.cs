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
    /// Prepares, validates, and executes the function "transactions.get_transaction_master_id_by_stock_master_id(_stock_master_id bigint)" on the database.
    /// </summary>
    public class GetTransactionMasterIdByStockMasterIdProcedure : DbAccess, IGetTransactionMasterIdByStockMasterIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_transaction_master_id_by_stock_master_id";
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
        /// Maps to "_stock_master_id" argument of the function "transactions.get_transaction_master_id_by_stock_master_id".
        /// </summary>
        public long StockMasterId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_transaction_master_id_by_stock_master_id(_stock_master_id bigint)" on the database.
        /// </summary>
        public GetTransactionMasterIdByStockMasterIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.get_transaction_master_id_by_stock_master_id(_stock_master_id bigint)" on the database.
        /// </summary>
        /// <param name="stockMasterId">Enter argument value for "_stock_master_id" parameter of the function "transactions.get_transaction_master_id_by_stock_master_id".</param>
        public GetTransactionMasterIdByStockMasterIdProcedure(long stockMasterId)
        {
            this.StockMasterId = stockMasterId;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.get_transaction_master_id_by_stock_master_id".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public long Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetTransactionMasterIdByStockMasterIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.get_transaction_master_id_by_stock_master_id(@StockMasterId);";

            query = query.ReplaceWholeWord("@StockMasterId", "@0::bigint");


            List<object> parameters = new List<object>();
            parameters.Add(this.StockMasterId);

            return Factory.Scalar<long>(this._Catalog, query, parameters.ToArray());
        }


    }
}