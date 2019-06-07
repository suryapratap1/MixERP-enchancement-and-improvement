using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;
using System.Collections.Generic;
using System.Linq;

namespace MixERP.Net.Common.Helpers
{
    public static class CatalogHelper
    {
        public static void ValidateCatalog(string catalog)
        {
            if (string.IsNullOrWhiteSpace(catalog))
            {
                return;
            }

            string catalogs = ConfigurationHelper.GetDbServerParameter("Catalogs");
            string meta = ConfigurationHelper.GetDbServerParameter("MetaDatabase");

            List<string> list = catalogs.Split(',').Select(p => p.Trim()).ToList();
            list.Add(meta);

            if (!list.Contains(catalog))
            {
                throw new MixERPException(Titles.AccessIsDenied);
            }
        }
    }
}