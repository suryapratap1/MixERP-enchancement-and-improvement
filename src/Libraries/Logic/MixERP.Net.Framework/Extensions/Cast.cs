using System.ComponentModel;

namespace MixERP.Net.Framework.Extensions
{
    public static class Cast
    {
        public static T To<T>(this string input)
        {
            T d = default(T);

            if (string.IsNullOrWhiteSpace(input))
            {
                return d;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)converter.ConvertFromString(input);
        }

        public static T To<T>(this string input, T or)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return or;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)converter.ConvertFromString(input);
        }

        public static T To<T>(this object input)
        {
            T d = default(T);

            if (input == null)
            {
                return d;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)converter.ConvertFromString(input.ToString());
        }

        public static T To<T>(this object input, T or)
        {
            if (input == null)
            {
                return or;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)converter.ConvertFromString(input.ToString());
        }
    }
}