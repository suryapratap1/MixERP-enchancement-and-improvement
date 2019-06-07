using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;

namespace MixERP.Net.WebControls.ReportEngine.Data.Connection
{
    public static class DbConnection
    {
        public static string ReportConnectionString(string catalog)
        {
            string host = ConfigurationHelper.GetDbServerParameter("Server");
            int port = Conversion.TryCastInteger(ConfigurationHelper.GetDbServerParameter("Port"));
            string userName = ConfigurationHelper.GetDbServerParameter("ReportUserId");
            string password = ConfigurationHelper.GetDbServerParameter("ReportUserPassword");

            if (string.IsNullOrWhiteSpace(host))
            {
                return DbFactory.DbConnection.GetConnectionString(catalog);
            }

            return DbFactory.DbConnection.GetConnectionString(host, catalog, userName, password, port);
        }
    }
}