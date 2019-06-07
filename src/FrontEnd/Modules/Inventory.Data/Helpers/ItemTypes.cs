using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class ItemTypes
    {
        public static IEnumerable<ItemType> GetItemTypes(string catalog)
        {
            const string sql = "SELECT * FROM core.item_types;";
            return Factory.Get<ItemType>(catalog, sql);
        }
    }
}
