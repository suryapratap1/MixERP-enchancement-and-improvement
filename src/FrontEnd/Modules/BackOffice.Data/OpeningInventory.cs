using MixERP.Net.Common;
using MixERP.Net.DbFactory;
using Npgsql;

namespace MixERP.Net.Core.Modules.BackOffice.Data
{
    public static class OpeningInventory
    {
        public static bool Exists(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM transactions.opening_inventory_exists(@OfficeId::integer);";

            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@OfficeId", officeId);

                return Conversion.TryCastBoolean(DbOperation.GetScalarValue(catalog, command));
            }
        }
    }
}