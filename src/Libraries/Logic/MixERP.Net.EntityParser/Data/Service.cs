using System.Collections.Generic;
using System.Linq;
using MixERP.Net.DbFactory;
using MixERP.Net.i18n;
using PetaPoco;

namespace MixERP.Net.EntityParser.Data
{
    public static class Service
    {
        public static IEnumerable<T> GetView<T>(string catalog, T poco, string tableName, string keyName, long page,
            List<Filter> filters, bool byOffice,
            int officeId, bool showall,
            long pageSize)
        {
            Sql sql = Sql.Builder.Append("SELECT * FROM " + Sanitizer.SanitizeIdentifierName(tableName)).Append("WHERE 1 = 1");

            if (byOffice)
            {
                sql.Append("AND office_id IN (SELECT * FROM office.get_office_ids(@0))", officeId);
            }

            AddFilters(ref sql, poco, filters);

            if (!string.IsNullOrWhiteSpace(keyName))
            {
                sql.OrderBy(keyName);
            }
            else
            {
                sql.Append("ORDER BY 1");
            }

            if (!showall)
            {
                long offset = (page - 1) * pageSize;

                sql.Append("LIMIT @0", pageSize);
                sql.Append("OFFSET @0", offset);
            }

            return Factory.Get<T>(catalog, sql);
        }

        public static IEnumerable<T> ForDownloadTemplate<T>(string catalog, T poco, string tableName, string keyName, bool byOffice,
            int officeId, bool includeData)
        {
            Sql sql = Sql.Builder.Append("SELECT * FROM " + Sanitizer.SanitizeIdentifierName(tableName)).Where("1 = 1");

            if (!includeData)
            {
                sql.Append("AND 1 = 0");
            }

            if (byOffice)
            {
                sql.Append("AND office_id IN (SELECT * FROM office.get_office_ids(@0))", officeId);
            }

            if (!string.IsNullOrWhiteSpace(keyName))
            {
                sql.OrderBy(keyName);
            }
            else
            {
                sql.Append("ORDER BY 1");
            }

            return Factory.Get<T>(catalog, sql);
        }

        public static long GetTotalPages<T>(string catalog, T poco, string tableName, List<Filter> filters,
            bool byOffice, int officeId,
            bool showall, long pageSize)
        {
            Sql sql = Sql.Builder.Append("SELECT ceiling(COUNT(*) / @0::numeric) FROM " + Sanitizer.SanitizeIdentifierName(tableName), pageSize);

            sql.Append("WHERE 1 = 1");

            if (byOffice)
            {
                sql.Append("AND office_id IN (SELECT * FROM office.get_office_ids(@0))", officeId);
            }

            AddFilters(ref sql, poco, filters);


            return Factory.Scalar<long>(catalog, sql);
        }

        public static void AddFilters<T>(ref Sql sql, T poco, List<Filter> filters)
        {
            if (filters == null || filters.Count().Equals(0))
            {
                return;
            }

            foreach (Filter filter in filters)
            {
                if (string.IsNullOrWhiteSpace(filter.ColumnName))
                {
                    if (!string.IsNullOrWhiteSpace(filter.PropertyName))
                    {
                        filter.ColumnName = PocoHelper.GetColumnName(poco, filter.PropertyName);
                    }
                }

                string column = Sanitizer.SanitizeIdentifierName(filter.ColumnName);

                if (string.IsNullOrWhiteSpace(column) || !PocoHelper.HasColumn(poco, filter.ColumnName))
                {
                    continue;
                }

                var statement = filter.FilterStatement;

                if (statement == null || statement.ToUpperInvariant() != "OR")
                {
                    statement = "AND";
                }

                statement += " ";

                switch ((FilterCondition) filter.FilterCondition)
                {
                    case FilterCondition.IsEqualTo:
                        sql.Append(statement + Sanitizer.SanitizeIdentifierName(column) + " = @0", filter.FilterValue);
                        break;
                    case FilterCondition.IsNotEqualTo:
                        sql.Append(statement + Sanitizer.SanitizeIdentifierName(column) + " != @0", filter.FilterValue);
                        break;
                    case FilterCondition.IsLessThan:
                        sql.Append(statement + Sanitizer.SanitizeIdentifierName(column) + " < @0", filter.FilterValue);
                        break;
                    case FilterCondition.IsLessThanEqualTo:
                        sql.Append(statement + Sanitizer.SanitizeIdentifierName(column) + " <= @0", filter.FilterValue);
                        break;
                    case FilterCondition.IsGreaterThan:
                        sql.Append(statement + Sanitizer.SanitizeIdentifierName(column) + " > @0", filter.FilterValue);
                        break;
                    case FilterCondition.IsGreaterThanEqualTo:
                        sql.Append(statement + Sanitizer.SanitizeIdentifierName(column) + " >= @0", filter.FilterValue);
                        break;
                    case FilterCondition.IsBetween:
                        sql.Append(statement + Sanitizer.SanitizeIdentifierName(column) + " BETWEEN @0 AND @1", filter.FilterValue, filter.FilterAndValue);
                        break;
                    case FilterCondition.IsNotBetween:
                        sql.Append(statement + Sanitizer.SanitizeIdentifierName(column) + " NOT BETWEEN @0 AND @1", filter.FilterValue, filter.FilterAndValue);
                        break;
                    case FilterCondition.IsLike:
                        sql.Append(statement + " lower(" + Sanitizer.SanitizeIdentifierName(column) + ") LIKE @0",
                            "%" + filter.FilterValue.ToLower(CultureManager.GetCurrent()) + "%");
                        break;
                    case FilterCondition.IsNotLike:
                        sql.Append(statement + " lower(" + Sanitizer.SanitizeIdentifierName(column) + ") NOT LIKE @0",
                            "%" + filter.FilterValue.ToLower(CultureManager.GetCurrent()) + "%");
                        break;
                }
            }
        }

        #region Filters

        public static List<Filter> GetFilters(string catalog, string tableName, string filterName)
        {
            const string sql = "SELECT * FROM core.filters WHERE object_name=@0 AND filter_name=@1;";

            return Factory.Get<Filter>(catalog, sql, tableName, filterName).ToList();
        }

        public static void SaveFilter(string catalog, string tableName, List<Filter> filters)
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                return;
            }

            List<string> items = filters.Select(f => f.FilterName).Distinct().ToList();

            if (items.Count().Equals(0))
            {
                return;
            }

            foreach (string item in items)
            {
                const string sql = "DELETE FROM core.filters WHERE object_name=@0 AND filter_name=@1;";
                Factory.NonQuery(catalog, sql, tableName, item);
            }

            foreach (Filter filter in filters)
            {
                filter.ObjectName = tableName;
                Factory.Insert(catalog, filter);
            }
        }

        public static T GetViewForEdit<T>(string catalog, string tableName, string primaryKey, object primaryKeyValue)
        {
            string sql = "SELECT * FROM " + Sanitizer.SanitizeIdentifierName(tableName);
            sql += " WHERE " + Sanitizer.SanitizeIdentifierName(primaryKey) + "=@0;";

            return Factory.Get<T>(catalog, sql, primaryKeyValue).FirstOrDefault();
        }

        public static void Delete(string catalog, string tableName, string primaryKey, object primaryKeyValue)
        {
            string sql = "DELETE FROM " + Sanitizer.SanitizeIdentifierName(tableName);
            sql += " WHERE " + Sanitizer.SanitizeIdentifierName(primaryKey) + "=@0;";

            Factory.NonQuery(catalog, sql, primaryKeyValue);
        }

        public static List<dynamic> GetFilterNames(string catalog, string tableName)
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                return null;
            }

            const string sql = "SELECT DISTINCT filter_name, is_default FROM core.filters WHERE object_name=@0;";
            return Factory.Get<dynamic>(catalog, sql, tableName).ToList();
        }

        public static void MakeDefaultFilter(string catalog, string tableName, string filterName)
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                return;
            }

            const string sql = "UPDATE core.filters SET is_default=(filter_name=@1) WHERE object_name=@0;";
            Factory.NonQuery(catalog, sql, tableName, filterName);
        }

        #endregion
    }
}