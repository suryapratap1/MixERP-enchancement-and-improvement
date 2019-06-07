using MixERP.Net.DbFactory;
using Npgsql;
using System;
using System.Data;

namespace MixERP.Net.Core.Modules.Finance.Data.Reports
{
    public static class TrialBalance
    {
        public static DataTable GetTrialBalance(string catalog, DateTime from, DateTime to, int userId, int officeId, bool compact, decimal factor, bool changeSideWhenNegative, bool includeZeroBalanceAccounts)
        {
            if (to < from)
            {
                return null;
            }

            const string sql = "SELECT * FROM transactions.get_trial_balance(@From::date, @To::date, @UserId::integer, @OfficeId::integer, @Compact::boolean, @Factor::decimal(24,4), @ChangeSideWhenNegative::boolean, @IncludeZeroBalanceAccounts::boolean) ORDER BY id;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@From", from);
                command.Parameters.AddWithValue("@To", to);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@Compact", compact);
                command.Parameters.AddWithValue("@Factor", factor);
                command.Parameters.AddWithValue("@ChangeSideWhenNegative", changeSideWhenNegative);
                command.Parameters.AddWithValue("@IncludeZeroBalanceAccounts", includeZeroBalanceAccounts);

                return DbOperation.GetDataTable(catalog, command);
            }
        }
    }
}