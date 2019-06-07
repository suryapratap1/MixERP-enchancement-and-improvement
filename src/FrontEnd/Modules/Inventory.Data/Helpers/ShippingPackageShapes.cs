using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class ShippingPackageShapes
    {
        public static IEnumerable<ShippingPackageShape> GetPreferredShippingPackageShapes(string catalog)
        {
            const string sql = "SELECT * FROM core.shipping_package_shapes";
            return Factory.Get<ShippingPackageShape>(catalog, sql);
        }
    }
}