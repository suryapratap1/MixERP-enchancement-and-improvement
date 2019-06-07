using MixERP.Net.DbFactory;
using Npgsql;
using System;
using System.Data;

namespace MixERP.Net.Core.Modules.Finance.Data.Reports
{
    public static class BalanceSheet
    {
        public static DataTable GetBalanceSheet(string catalog, DateTime previousPeriod, DateTime currentPeriod, int userId, int officeId, int factor)
        {
            const string sql = "SELECT * FROM transactions.get_balance_sheet(@Previous::date, @Current::date, @UserId::integer, @OfficeId::integer, @Factor::integer)";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@Previous", previousPeriod);
                command.Parameters.AddWithValue("@Current", currentPeriod);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@Factor", factor);

                return DbOperation.GetDataTable(catalog, command);
            }
        }
    }
}