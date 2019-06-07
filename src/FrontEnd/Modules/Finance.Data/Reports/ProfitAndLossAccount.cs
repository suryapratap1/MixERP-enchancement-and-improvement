using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.DbFactory;
using Npgsql;
using System;
using System.Data;

namespace MixERP.Net.Core.Modules.Finance.Data.Reports
{
    public static class ProfitAndLossAccount
    {
        public static DataTable GetPLAccount(string catalog, DateTime from, DateTime to, int userId, int officeId, bool compact, decimal factor)
        {
            const string sql = "SELECT transactions.get_profit_and_loss_statement(@From::date, @To::date, @UserId::integer, @OfficeId::integer, @Factor::integer, @Compact::boolean);";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@From", from);
                command.Parameters.AddWithValue("@To", to);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@Factor", factor);
                command.Parameters.AddWithValue("@Compact", compact);

                return JSONHelper.JsonToDataTable(Conversion.TryCastString(DbOperation.GetScalarValue(catalog, command)));
            }
        }
    }
}