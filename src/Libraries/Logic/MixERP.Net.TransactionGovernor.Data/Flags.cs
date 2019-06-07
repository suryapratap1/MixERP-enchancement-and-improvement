using MixERP.Net.DbFactory;
using Npgsql;
using System.Collections.ObjectModel;

namespace MixERP.Net.TransactionGovernor.Data
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flags"
        )]
    public static class Flags
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms",
            MessageId = "Flag"),
         System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms",
             MessageId = "flag")]
        public static void CreateFlag(string catalog, int userId, int flagTypeId, string resourceName,
            string resourceKey, Collection<string> resourceIds)
        {
            if (resourceIds == null)
            {
                return;
            }

            const string sql = "SELECT core.create_flag(@UserId, @FlagTypeId, @Resource, @ResourceKey, @ResourceId);";

            foreach (string resourceId in resourceIds)
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@FlagTypeId", flagTypeId);
                    command.Parameters.AddWithValue("@Resource", resourceName);
                    command.Parameters.AddWithValue("@ResourceKey", resourceKey);
                    command.Parameters.AddWithValue("@ResourceId", resourceId);

                    DbOperation.ExecuteNonQuery(catalog, command);
                }
            }
        }
    }
}