using MixERP.Net.i18n;
using Newtonsoft.Json;

namespace MixERP.Net.Api.Framework
{
    public static class JsonHelper
    {
        public static JsonSerializerSettings GetJsonSerializerSettings()
        {
            return new JsonSerializerSettings
            {
                Culture = CultureManager.GetCurrent(),
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Auto,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                DateParseHandling = DateParseHandling.DateTime,
                FloatParseHandling = FloatParseHandling.Decimal,
                FloatFormatHandling = FloatFormatHandling.DefaultValue
            };
        }

        public static JsonSerializer GetJsonSerializer()
        {
            return JsonSerializer.Create(GetJsonSerializerSettings());
        }
    }
}