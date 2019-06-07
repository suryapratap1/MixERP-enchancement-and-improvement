using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Shippers
    {
        public static IEnumerable<Shipper> GetShippers(string catalog)
        {
            const string sql = "SELECT * FROM core.shippers ORDER BY shipper_id;";
            return Factory.Get<Shipper>(catalog, sql);
        }
    }
}