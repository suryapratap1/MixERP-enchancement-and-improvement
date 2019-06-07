using MixERP.Net.DbFactory;

namespace MixERP.Net.FrontEnd.Data.Helpers
{
    public static class ServerConnectivity
    {
        public static bool IsDbServerAvailable(string catalog)
        {
            return DbOperation.IsServerAvailable(catalog);
        }
    }
}