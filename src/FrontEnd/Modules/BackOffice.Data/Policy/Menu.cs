using System.Collections.Generic;
using MixERP.Net.Entities.Policy;
using PetaPoco;

namespace MixERP.Net.Core.Modules.BackOffice.Data.Policy
{
    public static class Menu
    {
        public static IEnumerable<DbGetMenuPolicyResult> GetMenuPolicy(string catalog, int userId, int officeId,
            string culture)
        {
            const string sql = "SELECT * FROM policy.get_menu_policy(@0::integer, @1::integer, @2::text);";
            return Factory.Get<DbGetMenuPolicyResult>(catalog, sql, userId, officeId, culture);
        }

        public static void SaveMenuPolicy(string catalog, int userId, int officeId, string menus)
        {
            const string sql =
                "SELECT * FROM policy.save_menu_policy(@0::integer, @1::integer, string_to_array(@2, ',')::varchar[]::int[]);";
            Factory.NonQuery(catalog, sql, userId, officeId, menus);
        }
    }
}