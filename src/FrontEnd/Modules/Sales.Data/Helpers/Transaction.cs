using MixERP.Net.Common;
using MixERP.Net.DbFactory;
using Npgsql;

namespace MixERP.Net.Core.Modules.Sales.Data.Helpers
{
    public static class Transaction
    {
        public static decimal GetExchangeRate(string catalog, int officeId, string sourceCurrencyCode, string destinationCurrencyCode)
        {
            const string sql = "SELECT transactions.get_exchange_rate(@OfficeId, @SourceCurrencyCode, @DestinationCurrencyCode);";

            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@SourceCurrencyCode", sourceCurrencyCode);
                command.Parameters.AddWithValue("@DestinationCurrencyCode", destinationCurrencyCode);

                return Conversion.TryCastDecimal(DbOperation.GetScalarValue(catalog, command));
            }
        }
    }
}