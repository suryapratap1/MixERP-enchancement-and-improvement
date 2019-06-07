using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Transactions
{
    public static class StockTransferAcknowledgement
    {
        public static long Receive(string catalog, int officeId, int userId, long loginId, long requestId)
        {
            const string sql =
                "SELECT * FROM transactions.post_stock_transfer_acknowledgement(@0::integer, @1::integer, @2::bigint, @3::bigint);";
            return Factory.Scalar<long>(catalog, sql, officeId, userId, loginId, requestId);
        }
    }
}