using MixERP.Net.Common;
using MixERP.Net.DbFactory;
using Npgsql;

namespace MixERP.Net.TransactionGovernor.Data
{
    public static class StockTransaction
    {
        public static bool IsValidPartyByStockMasterId(string catalog, long stockMasterId, string partyCode)
        {
            const string sql = "SELECT transactions.is_valid_party_by_stock_master_id(@StockMasterId, core.get_party_id_by_party_code(@PartyCode));";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@StockMasterId", stockMasterId);
                command.Parameters.AddWithValue("@PartyCode", partyCode);

                return Conversion.TryCastBoolean(DbOperation.GetScalarValue(catalog, command));
            }
        }

        public static bool IsValidPartyByTransactionMasterId(string catalog, long transactionMasterId, string partyCode)
        {
            const string sql = "SELECT transactions.is_valid_party_by_transaction_master_id(@TransactionMasterId, core.get_party_id_by_party_code(@PartyCode));";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@TransactionMasterId", transactionMasterId);
                command.Parameters.AddWithValue("@PartyCode", partyCode);

                return Conversion.TryCastBoolean(DbOperation.GetScalarValue(catalog, command));
            }
        }

        public static bool IsValidStockTransaction(string catalog, long transactionMasterId)
        {
            const string sql = "SELECT transactions.is_valid_stock_transaction_by_transaction_master_id(@TransactionMasterId);";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@TransactionMasterId", transactionMasterId);

                return Conversion.TryCastBoolean(DbOperation.GetScalarValue(catalog, command));
            }
        }

        public static bool IsValidStockTransactionByStockMasterId(string catalog, long stockMasterId)
        {
            const string sql = "SELECT transactions.is_valid_stock_transaction_by_stock_master_id(@StockMasterId::bigint);";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@StockMasterId", stockMasterId);

                return Conversion.TryCastBoolean(DbOperation.GetScalarValue(catalog, command));
            }
        }
    }
}