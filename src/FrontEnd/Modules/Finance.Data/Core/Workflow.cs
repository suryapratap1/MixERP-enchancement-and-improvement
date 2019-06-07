using System.Linq;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Finance.Data.Core
{
    public static class Workflow
    {
        public static DbGetWorkflowModelResult GetWorkflowModel(string catalog)
        {
            const string sql = "SELECT * FROM core.get_workflow_model();";
            return Factory.Get<DbGetWorkflowModelResult>(catalog, sql).FirstOrDefault();
        }
    }
}