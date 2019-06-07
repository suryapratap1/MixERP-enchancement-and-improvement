using PetaPoco;

namespace MixERP.Net.Common.Helpers
{
    public static class DbConfig
    {
        public static string GetMixERPParameter(string catalog, string key)
        {
            const string sql = "SELECT value FROM config.mixerp WHERE key=@0";
            return Factory.Scalar<string>(catalog, sql, key);
        }

        public static string GetAttachmentParameter(string catalog, string key)
        {
            const string sql = "SELECT value FROM config.attachment_factory WHERE key=@0";
            return Factory.Scalar<string>(catalog, sql, key);
        }

        public static string GetCurrencylayerParameter(string catalog, string key)
        {
            const string sql = "SELECT value FROM config.currency_layer WHERE key=@0";
            return Factory.Scalar<string>(catalog, sql, key);
        }

        public static string GetOpenExchangeRatesParameter(string catalog, string key)
        {
            const string sql = "SELECT value FROM config.open_exchange_rates WHERE key=@0"; 
            return Factory.Scalar<string>(catalog, sql, key);
        }

        public static string GetDbParameter(string catalog, string key)
        {
            const string sql = "SELECT value FROM config.db_parameters WHERE key=@0";
            return Factory.Scalar<string>(catalog, sql, key);
        }

        public static string GetScrudParameter(string catalog, string key)
        {
            const string sql = "SELECT value FROM config.scrud_factory WHERE key=@0";
            return Factory.Scalar<string>(catalog, sql, key);
        }

        public static bool GetSwitch(string catalog, string key)
        {
            const string sql = "SELECT value FROM config.switches WHERE key=@0";
            return Factory.Scalar<bool>(catalog, sql, key);
        }
    }
}