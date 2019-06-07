using MixERP.Net.DbFactory;
using Npgsql;

namespace MixERP.Net.TransactionGovernor.Data.Verification
{
    public static class Withdrawal
    {
        public static bool WithdrawTransaction(string catalog, bool isStockTransferRequest, long transactionMasterId, int userId, string reason, short status)
        {
            string sql = @"UPDATE transactions.transaction_master SET 
                                verification_status_id=@Status, 
                                verified_by_user_id=@UserId, 
                                verification_reason=@Reason,
                                last_verified_on = NOW()
                                WHERE transactions.transaction_master.transaction_master_id=@TransactionMasterId;";

            if (isStockTransferRequest)
            {
                sql = @"UPDATE transactions.inventory_transfer_requests SET 
                                authorization_status_id=@Status, 
                                authorized_by_user_id=@UserId, 
                                authorization_reason=@Reason,
                                authorized_on = NOW()
                                WHERE transactions.inventory_transfer_requests.inventory_transfer_request_id=@TransactionMasterId;";
            }

            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Reason", reason);
                command.Parameters.AddWithValue("@TransactionMasterId", transactionMasterId);

                return DbOperation.ExecuteNonQuery(catalog, command);
            }
        }
    }
}