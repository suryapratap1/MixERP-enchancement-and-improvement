using MixERP.Net.Entities;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Data.Helpers
{
    public static class Parties
    {
        public static string GetEmailAddress(string catalog, TranBook tranBook, SubTranBook subTranBook, long tranId)
        {
            string sql =
                "SELECT core.get_email_address_by_party_id(party_id) FROM transactions.non_gl_stock_master WHERE non_gl_stock_master_id=@0::bigint;";

            if (subTranBook == SubTranBook.Delivery || subTranBook == SubTranBook.Direct ||
                subTranBook == SubTranBook.Invoice || subTranBook == SubTranBook.Return)
            {
                sql =
                    "SELECT core.get_email_address_by_party_id(party_id) FROM transactions.stock_master WHERE transaction_master_id=@0::bigint;";
            }

            if (subTranBook == SubTranBook.Receipt)
            {
                sql =
                    "SELECT core.get_email_address_by_party_id(party_id) FROM transactions.customer_receipts WHERE transaction_master_id=@0::bigint;";
            }

            return Factory.Scalar<string>(catalog, sql, tranId);
        }

        public static string GetEmailAddress(string catalog, string partyCode)
        {
            const string sql = "SELECT email FROM core.parties WHERE party_code =@0";
            return Factory.Scalar<string>(catalog, sql, partyCode);
        }
    }
}