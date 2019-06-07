using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class PriceTypes
    {
        public static IEnumerable<PriceType> GetPriceTypes(string catalog)
        {
            const string sql = "SELECT * FROM core.price_types ORDER BY price_type_id;";
            return Factory.Get<PriceType>(catalog, sql);
        }
    }
}