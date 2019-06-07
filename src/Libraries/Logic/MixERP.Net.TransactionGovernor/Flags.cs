using System.Collections.ObjectModel;

namespace MixERP.Net.TransactionGovernor
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags")]
    public static class Flags
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "flag")]
        public static void CreateFlag(string catalog, int userId, int flagTypeId, string resourceName, string resourceKey, Collection<string> resourceIds)
        {
            if (userId <= 0)
            {
                return;
            }

            if (flagTypeId <= 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(resourceName))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(resourceKey))
            {
                return;
            }

            if (resourceIds == null)
            {
                return;
            }

            Data.Flags.CreateFlag(catalog, userId, flagTypeId, resourceName, resourceKey, resourceIds);
        }
    }
}