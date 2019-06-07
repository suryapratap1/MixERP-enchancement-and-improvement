using System.Collections.Generic;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Brands
    {
        public static IEnumerable<Brand> GetBrands(string catalog)
        {
            const string sql = "SELECT * FROM core.brands;";
            return Factory.Get<Brand>(catalog, sql);
        }
    }
}