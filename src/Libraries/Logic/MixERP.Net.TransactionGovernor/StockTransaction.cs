namespace MixERP.Net.TransactionGovernor
{
    public static class StockTransaction
    {
        public static bool IsValidPartyByStockMasterId(string catalog, long stockMasterId, string partyCode)
        {
            if (stockMasterId <= 0 || string.IsNullOrWhiteSpace(partyCode))
            {
                return false;
            }

            return Data.StockTransaction.IsValidPartyByStockMasterId(catalog, stockMasterId, partyCode);
        }

        public static bool IsValidPartyByTransactionMasterId(string catalog, long transactionMasterId, string partyCode)
        {
            if (transactionMasterId <= 0 || string.IsNullOrWhiteSpace(partyCode))
            {
                return false;
            }

            return Data.StockTransaction.IsValidPartyByTransactionMasterId(catalog, transactionMasterId, partyCode);
        }

        public static bool IsValidStockTransactionByStockMasterId(string catalog, long stockMasterId)
        {
            if (stockMasterId <= 0)
            {
                return false;
            }

            return Data.StockTransaction.IsValidStockTransactionByStockMasterId(catalog, stockMasterId);
        }

        public static bool IsValidStockTransactionByTransactionMasterId(string catalog, long transactionMasterId)
        {
            if (transactionMasterId <= 0)
            {
                return false;
            }

            return Data.StockTransaction.IsValidStockTransaction(catalog, transactionMasterId);
        }

    }
}