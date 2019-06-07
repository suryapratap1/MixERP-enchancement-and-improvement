using System;
using System.Collections.Generic;
using MixERP.Net.Entities.Transactions;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Reports
{
    public static class StockItems
    {
        public static IEnumerable<DbListClosingStockResult> ListClosingStock(string catalog, int storeId)
        {
            const string sql = "SELECT * FROM transactions.list_closing_stock(@0::integer);";
            return Factory.Get<DbListClosingStockResult>(catalog, sql, storeId);
        }

        public static IEnumerable<DbGetStockAccountStatementResult> GetAccountStatement(string catalog, DateTime @from,
            DateTime to, int userId, string itemCode, int storeId)
        {
            const string sql =
                "SELECT * FROM transactions.get_stock_account_statement(@0::date, @1::date, @2::integer, @3::text, @4::integer);";
            return Factory.Get<DbGetStockAccountStatementResult>(catalog, sql, from, to, userId, itemCode, storeId);
        }
    }
}