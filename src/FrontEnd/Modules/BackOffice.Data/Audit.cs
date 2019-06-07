using System.Linq;
using MixERP.Net.Entities.Audit;
using PetaPoco;

namespace MixERP.Net.Core.Modules.BackOffice.Data
{
    public class Audit
    {
        public static DbGetOfficeInformationModelResult GetOfficeInformationModel(string catalog, int userId)
        {
            const string sql = "SELECT * FROM audit.get_office_information_model(@0::integer);";
            return Factory.Get<DbGetOfficeInformationModelResult>(catalog, sql, userId).FirstOrDefault();
        }
    }
}