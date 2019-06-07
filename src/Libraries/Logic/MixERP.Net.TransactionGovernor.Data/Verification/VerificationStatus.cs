using System.Linq;
using PetaPoco;

namespace MixERP.Net.TransactionGovernor.Data.Verification
{
    public static class VerificationStatus
    {
        public static Entities.Transactions.Models.VerificationModel GetVerificationStatus(string catalog,
            long transactionMasterId, bool isStockTransferRequest)
        {
            string sql = @"SELECT 
                             verification_status_id, 
                             office.get_user_name_by_user_id(verified_by_user_id) AS verified_by_user_name,
                             verified_by_user_id,
                             last_verified_on, 
                             verification_reason
                         FROM transactions.transaction_master
                         WHERE transaction_master_id=@0;";

            if (isStockTransferRequest)
            {
                sql = @"SELECT 
                        authorization_status_id AS verification_status_id, 
                        office.get_user_name_by_user_id(authorized_by_user_id) AS verified_by_user_name,
                        authorized_by_user_id as verified_by_user_id,
                        authorized_on AS last_verified_on, 
                        authorization_reason AS verification_reason
                    FROM transactions.inventory_transfer_requests
                    WHERE inventory_transfer_request_id=@0;";
            }


            return
                Factory.Get<Entities.Transactions.Models.VerificationModel>(catalog, sql, transactionMasterId)
                    .SingleOrDefault();
        }
    }
}