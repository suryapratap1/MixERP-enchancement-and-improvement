using System.Collections.Generic;
using MixERP.Net.Entities.Localization;
using PetaPoco;

namespace MixERP.Net.Core.Modules.BackOffice.Data.Admin
{
    public static class LocalizeMixERP
    {
        public static void Save(string catalog, string cultureCode, string key, string value)
        {
            const string sql = "SELECT * FROM localization.add_localized_resource(@0, @1, @2);";
            Factory.NonQuery(catalog, sql, cultureCode, key, value);
        }

        public static IEnumerable<Culture> GetCultures(string catalog)
        {
            const string sql = "SELECT * FROM localization.cultures;";
            return Factory.Get<Culture>(catalog, sql);
        }
    }
}