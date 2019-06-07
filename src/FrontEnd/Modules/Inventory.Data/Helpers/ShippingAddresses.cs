using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class ShippingAddresses
    {
        public static IEnumerable<ShippingAddressView> GetShippingAddressView(string catalog, string partyCode)
        {
            return Factory.Get<ShippingAddressView>(catalog, "SELECT * FROM core.shipping_address_view WHERE party_id = core.get_party_id_by_party_code(@0);", partyCode);
        }
    }
}
