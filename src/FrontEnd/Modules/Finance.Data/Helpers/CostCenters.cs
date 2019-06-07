using System.Collections.Generic;
using MixERP.Net.Entities.Office;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Finance.Data.Helpers
{
    public static class CostCenters
    {
        public static IEnumerable<CostCenter> GetCostCenters(string catalog)
        {
            const string sql = "SELECT * FROM office.cost_centers ORDER BY cost_center_id;";
            return Factory.Get<CostCenter>(catalog, sql);
        }
    }
}