using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class SalesTaxes
    {
        public static IEnumerable<SalesTax> GetSalesTaxes(string catalog)
        {
            const string sql = "SELECT * FROM core.sales_taxes";
            return Factory.Get<SalesTax>(catalog, sql);
        }
    }
}