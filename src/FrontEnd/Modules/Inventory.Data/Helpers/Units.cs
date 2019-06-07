using System.Collections.Generic;
using MixERP.Net.DbFactory;
using Npgsql;
using System.Data;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Units
    {
        public static DataTable GetUnitViewByItemCode(string catalog, string itemCode)
        {
            const string sql = "SELECT * FROM core.get_associated_units_from_item_code(@ItemCode) ORDER BY unit_id;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@ItemCode", itemCode);

                return DbOperation.GetDataTable(catalog, command);
            }
        }

        public static bool UnitExistsByName(string catalog, string unitName)
        {
            const string sql = "SELECT 1 FROM core.units WHERE core.units.unit_name=@UnitName;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@UnitName", unitName);

                var value = DbOperation.GetScalarValue(catalog, command);
                if (value != null)
                {
                    return value.ToString().Equals("1");
                }
            }
            return false;
        }

        public static IEnumerable<Unit> GetUnits(string catalog)
        {
            const string sql = "SELECT * FROM core.units;";
            return Factory.Get<Unit>(catalog, sql);
        }
    }
}