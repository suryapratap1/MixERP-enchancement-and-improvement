using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.DbFactory;
using Npgsql;
using System;
using System.Data;

namespace MixERP.Net.Core.Modules.Finance.Data.Reports
{
    public static class CashFlow
    {
        public static DataTable GetDirectCashFlowStatement(string catalog, DateTime from, DateTime to, int userId, int officeId, decimal factor)
        {
            const string sql = "SELECT transactions.get_cash_flow_statement(@From::date, @To::date, @UserId::integer, @OfficeId::integer, @Factor::integer);";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@From", from);
                command.Parameters.AddWithValue("@To", to);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@Factor", factor);

                return JSONHelper.JsonToDataTable(Conversion.TryCastString(DbOperation.GetScalarValue(catalog, command)));
            }
        }
    }
}