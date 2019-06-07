using System.Collections.Generic;
using MixERP.Net.Entities.Office;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Stores
    {
        public static IEnumerable<Store> GetStores(string catalog, int officeId)
        {
            const string sql = "SELECT * FROM office.stores WHERE office_id IN (SELECT office.get_office_ids(@0));";
            return Factory.Get<Store>(catalog, sql, officeId);
        }

        public static IEnumerable<Store> GetStores(string catalog, int officeId, int userId)
        {
            const string sql = "SELECT * FROM office.get_stores(@0, @1)";
            return Factory.Get<Store>(catalog, sql, officeId, userId);
        }
    }
}