namespace MixERP.Net.TransactionGovernor.Verification
{
    public static class Status
    {
        public static Entities.Transactions.Models.VerificationModel GetVerificationStatus(string catalog, long transactionMasterId, bool isStockTransferRequest)
        {
            if (transactionMasterId <= 0)
            {
                return null;
            }

            return Data.Verification.VerificationStatus.GetVerificationStatus(catalog, transactionMasterId, isStockTransferRequest);
        }
    }
}