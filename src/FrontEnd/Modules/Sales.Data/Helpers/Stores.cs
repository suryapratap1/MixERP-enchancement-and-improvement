using System.Linq;
using MixERP.Net.Entities.Office;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Data.Helpers
{
    public static class Stores
    {
        public static bool IsSalesAllowed(string catalog, int storeId)
        {
            const string sql = "SELECT * FROM office.stores WHERE store_id=@0 and allow_sales;";
            return Factory.Get<Store>(catalog, sql, storeId).Count().Equals(1);
        }
    }
}