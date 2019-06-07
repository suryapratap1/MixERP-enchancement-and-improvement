using Newtonsoft.Json;
using System.Data;

namespace MixERP.Net.Common.Helpers
{
    public static class JSONHelper
    {
        public static DataTable JsonToDataTable(string json)
        {
            return JsonConvert.DeserializeObject<DataTable>(json);
        }
    }
}