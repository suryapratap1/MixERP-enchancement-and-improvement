using MixERP.Net.Common;
using MixERP.Net.DbFactory;
using MixERP.Net.Entities;
using Npgsql;

namespace MixERP.Net.Core.Modules.Purchase.Data.Helpers
{
    public static class Parties
    {
        public static string GetEmailAddress(string catalog, TranBook tranBook, SubTranBook subTranBook, long tranId)
        {
            string sql = "SELECT core.get_email_address_by_party_id(party_id) FROM transactions.non_gl_stock_master WHERE non_gl_stock_master_id=@TranId;";

            if (subTranBook == SubTranBook.Direct || subTranBook == SubTranBook.Receipt || subTranBook == SubTranBook.Invoice || subTranBook == SubTranBook.Return)
            {
                sql = "SELECT core.get_email_address_by_party_id(party_id) FROM transactions.stock_master WHERE transaction_master_id=@TranId;";
            }

            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@TranId", tranId);

                return Conversion.TryCastString(DbOperation.GetScalarValue(catalog, command));
            }
        }
    }
}