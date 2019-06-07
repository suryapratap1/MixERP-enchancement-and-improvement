using MixERP.Net.Common;
using MixERP.Net.Core.Modules.Finance.Data.Models;
using MixERP.Net.DbFactory;
using Npgsql;
using Serilog;
using System.Collections.Generic;

namespace MixERP.Net.Core.Modules.Finance.Data.Core
{
    public static class ExchangeRates
    {
        public static long SaveExchangeRates(string catalog, int officeId, string baseCurrency, IEnumerable<ExchangeRate> exchangeRates)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.GetConnectionString(catalog)))
            {
                connection.Open();

                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string sql = "UPDATE core.exchange_rates SET status = false WHERE office_id=@OfficeId";
                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@OfficeId", officeId);
                            command.ExecuteNonQuery();
                        }

                        sql = "INSERT INTO core.exchange_rates(office_id, status) SELECT @OfficeId, true RETURNING exchange_rate_id;";

                        long exchangeRateId;
                        using (NpgsqlCommand er = new NpgsqlCommand(sql, connection))
                        {
                            er.Parameters.AddWithValue("@OfficeId", officeId);

                            exchangeRateId = Conversion.TryCastLong(er.ExecuteScalar());
                        }

                        foreach (ExchangeRate exchangeRate in exchangeRates)
                        {
                            sql =
                                "INSERT INTO core.exchange_rate_details(exchange_rate_id, local_currency_code, foreign_currency_code, unit, exchange_rate) " +
                                "SELECT @ExchangeRateId, @LocalCurrencyCode, @ForiegnCurrencyCode, 1, @ExchangeRate;";
                            using (NpgsqlCommand rate = new NpgsqlCommand(sql, connection))
                            {
                                rate.Parameters.AddWithValue("@ExchangeRateId", exchangeRateId);
                                rate.Parameters.AddWithValue("@LocalCurrencyCode", baseCurrency);
                                rate.Parameters.AddWithValue("@ForiegnCurrencyCode", exchangeRate.CurrencyCode);
                                rate.Parameters.AddWithValue("@ExchangeRate", exchangeRate.Rate);

                                rate.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return exchangeRateId;
                    }
                    catch (NpgsqlException ex)
                    {
                        Log.Warning(@"Could not update exchange rate. {Exception}", ex);
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}