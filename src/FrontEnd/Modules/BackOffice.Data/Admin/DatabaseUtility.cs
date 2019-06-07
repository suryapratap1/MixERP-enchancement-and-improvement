using MixERP.Net.DbFactory;
using Npgsql;

namespace MixERP.Net.Core.Modules.BackOffice.Data.Admin
{
    /// <summary>
    ///     This class provides utility functions to execute routine PostgreSQL server functions.
    /// </summary>
    public class DatabaseUtility
    {
        /// <summary>
        ///     Asks the database server to analyze and collect statistics of the current database.
        ///     For further information, http://www.postgresql.org/docs/9.4/static/sql-analyze.html
        /// </summary>
        public void Analyze(string catalog)
        {
            const string sql = "ANALYZE;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.CommandTimeout = 3600;
                DbOperation.ExecuteNonQuery(catalog, command);
            }
        }

        /// <summary>
        ///     The vacuum command reclaims the storage space of the database server
        ///     against the dead/inactive database tuples.
        ///     For further information, http://www.postgresql.org/docs/9.4/static/sql-vacuum.html
        /// </summary>
        public void Vacuum(string catalog)
        {
            const string sql = "VACUUM;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.CommandTimeout = 3600;
                DbOperation.ExecuteNonQuery(catalog, command);
            }
        }

        /// <summary>
        ///     The vacuum full command frees the storage space of the database server against the
        ///     dead/inactive database tuples. For further information,
        ///     http://www.postgresql.org/docs/9.4/static/sql-vacuum.html.
        /// </summary>
        public void VacuumFull(string catalog)
        {
            const string sql = "VACUUM FULL;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.CommandTimeout = 3600;
                DbOperation.ExecuteNonQuery(catalog, command);
            }
        }
    }
}