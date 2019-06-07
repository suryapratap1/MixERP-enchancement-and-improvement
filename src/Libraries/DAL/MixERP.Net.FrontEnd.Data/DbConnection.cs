using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using Npgsql;

namespace MixERP.Net.FrontEnd.Data
{
    public static class DbConnection
    {
        public static string GetConnectionString()
        {
            string host = ConfigurationHelper.GetDbServerParameter("Server");
            const string database = "postgres";
            string userId = ConfigurationHelper.GetDbServerParameter("UserId");
            string password = ConfigurationHelper.GetDbServerParameter("Password");
            int port = Conversion.TryCastInteger(ConfigurationHelper.GetDbServerParameter("Port"));

            return GetConnectionString(host, database, userId, password, port);
        }

        public static string GetConnectionString(string host, string database, string username, string password,
            int port)
        {
            CatalogHelper.ValidateCatalog(database);

            NpgsqlConnectionStringBuilder connectionStringBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = host,
                Database = database,
                UserName = username,
                Password = password,
                Port = port,
                SyncNotification = true,
                Pooling = true,
                SSL = true,
                SslMode = SslMode.Prefer,
                MinPoolSize = 10,
                MaxPoolSize = 100,
                ApplicationName = "MixERP"
            };

            return connectionStringBuilder.ConnectionString;
        }
    }
}