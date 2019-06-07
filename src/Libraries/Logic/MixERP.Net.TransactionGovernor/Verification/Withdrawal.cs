using MixERP.Net.Entities;

namespace MixERP.Net.TransactionGovernor.Verification
{
    public static class Withdrawal
    {
        public static bool WithdrawTransaction(string catalog, bool isStockTransferRequest, long transactionMasterId, int userId, string reason)
        {
            const short status = (short)VerificationType.Withdrawn;

            return Data.Verification.Withdrawal.WithdrawTransaction(catalog, isStockTransferRequest, transactionMasterId, userId, reason, status);
        }
    }
}