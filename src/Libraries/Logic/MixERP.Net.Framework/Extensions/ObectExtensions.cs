using System;
using System.Linq;
using System.Reflection;

namespace MixERP.Net.Framework.Extensions
{
    public static class ObectExtensions
    {
        public static bool HasProperty<T>(this T obj, string propertyName)
        {
            return typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance).Any
                (
                p => p.Name.ToUpperInvariant() == propertyName.ToUpperInvariant()
                );
        }

        public static T? Parse<T>(this string str, Func<string, T> parser) where T : struct
        {
            if(string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            return parser(str);
        }
    }
}