using System.Collections.Generic;
using PetaPoco;

namespace MixERP.Net.FrontEnd.Data.Core
{
    public static class Menu
    {
        public static IEnumerable<Entities.Core.Menu> GetMenuCollection(string catalog, int officeId, int userId,
            string culture)
        {
            const string sql = "SELECT * FROM policy.get_menu(@0::integer, @1::integer, @2::text) ORDER BY menu_id;";
            return Factory.Get<Entities.Core.Menu>(catalog, sql, userId, officeId, culture);
        }
    }
}