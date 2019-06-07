using PetaPoco;

namespace MixERP.Net.TransactionGovernor.Data.Verification
{
    public static class Stack
    {
        public static int CountItemsInVerificationStack(string catalog, int officeId)
        {
            const string sql =
                "SELECT COUNT(*) FROM transactions.transaction_master WHERE verification_status_id = 0 AND office_id = @0 AND value_date <= transactions.get_value_date(@0);";

            return Factory.Scalar<int>(catalog, sql, officeId);
        }
    }
}