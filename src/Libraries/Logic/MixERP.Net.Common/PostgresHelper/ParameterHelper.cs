using Npgsql;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace MixERP.Net.Common.PostgresHelper
{
    public static class ParameterHelper
    {
        public static IEnumerable<NpgsqlParameter> AddBigintArrayParameter(Collection<long> items, string parameterPrefix)
        {
            Collection<NpgsqlParameter> collection = new Collection<NpgsqlParameter>();

            if (items != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    collection.Add(new NpgsqlParameter(parameterPrefix + i, items[i]));
                }
            }

            return collection;
        }

        public static string CreateBigintArrayParameter(Collection<long> collection, string pgType, string parameterPrefix)
        {
            if (collection == null)
            {
                return "NULL::" + pgType;
            }

            Collection<string> detailCollection = new Collection<string>();
            for (int i = 0; i < collection.Count; i++)
            {
                detailCollection.Add(string.Format(CultureInfo.InvariantCulture, "{0}{1}::{2}", parameterPrefix, i.ToString(CultureInfo.InvariantCulture), pgType));
            }

            return string.Join(",", detailCollection);
        }
    }
}