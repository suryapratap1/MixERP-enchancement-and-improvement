using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class ShippingMailTypes
    {
        public static IEnumerable<ShippingMailType> GetPreferredShippingMailTypes(string catalog)
        {
            const string sql = "SELECT * FROM core.shipping_mail_types";
            return Factory.Get<ShippingMailType>(catalog, sql);
        }
    }
}