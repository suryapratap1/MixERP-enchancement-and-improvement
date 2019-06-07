using MixERP.Net.DbFactory;
using Npgsql;
using System;
using System.Data;

namespace MixERP.Net.Core.Modules.Finance.Data.Reports
{
    public static class RetainedEarnings
    {
        public static DataTable GetRetainedEarningStatementDataTable(string catalog, DateTime date, int officeId, int factor)
        {
            const string sql = "SELECT * FROM transactions.get_retained_earnings_statement(@Date::date, @OfficeId::integer, @Factor::integer);";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@Factor", factor);

                return DbOperation.GetDataTable(catalog, command);
            }
        }
    }
}