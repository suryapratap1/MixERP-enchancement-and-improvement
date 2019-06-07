using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Office;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class ItemGroups
    {
        public static IEnumerable<ItemGroup> GetItemGroups(string catalog)
        {
            const string sql = "SELECT * FROM core.item_groups;";
            return Factory.Get<ItemGroup>(catalog, sql);
        }
    }
}
