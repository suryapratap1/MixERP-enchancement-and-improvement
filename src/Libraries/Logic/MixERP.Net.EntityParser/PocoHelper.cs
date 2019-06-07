using System;
using System.Linq;
using System.Reflection;
using MixERP.Net.Framework.Extensions;
using PetaPoco;

namespace MixERP.Net.EntityParser
{
    public class PocoHelper
    {
        public static string GetTableName<T>(T poco)
        {
            string name = poco.GetType().GetAttributeValue((TableNameAttribute attribute) => attribute.Value);

            return name;
        }

        public static string GetKeyName<T>(T poco)
        {
            string name = poco.GetType().GetAttributeValue((PrimaryKeyAttribute attribute) => attribute.Value);

            return name;
        }

        public static string GetKeyProperty<T>(T poco)
        {
            string key = GetKeyName(poco);

            var a = poco.GetType()
                .GetProperties()
                .FirstOrDefault(p => p.GetCustomAttributes(typeof (ColumnAttribute), true)
                            .Any(ca => ((ColumnAttribute) ca).Name.Equals(key)));

            return a?.Name;
        }

        public static object GetInstanceOf(string className)
        {
            Type type = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
                .First(t => t.Name == className && typeof (IPoco).IsAssignableFrom(t));

            return Activator.CreateInstance(type);
        }

        public static bool HasColumn<T>(T poco, string columnName)
        {
            var type = poco.GetType();
            foreach (PropertyInfo a in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                int attributes = a.GetCustomAttributes(typeof (ColumnAttribute), false)
                    .Cast<ColumnAttribute>()
                    .Count(b => b.Name.ToUpperInvariant().Equals(columnName.ToUpperInvariant()));

                if (attributes > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static string GetColumnName<T>(T poco, string propertyName)
        {
            var type = poco.GetType();

            var a = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .FirstOrDefault(p => p.Name.Equals(propertyName));

            var attr = a?.GetCustomAttributes(typeof (ColumnAttribute), false)
                .Cast<ColumnAttribute>().FirstOrDefault();

            if (attr != null)
            {
                return attr.Name;
            }

            return string.Empty;
        }
    }
}