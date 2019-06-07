using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using MixERP.Net.Common;
using MixERP.Net.DbFactory;
using MixERP.Net.Entities.Transactions;
using MixERP.Net.i18n.Resources;
using Npgsql;

namespace MixERP.Net.Core.Modules.BackOffice.Data.OneTimeSetup
{
    public static class OpeningInventory
    {
        public static long Save(string catalog, int officeId, int userId, long loginId, DateTime valueDate,
            string referenceNumber, string statementReference, Collection<OpeningStockType> details)
        {
            if (details == null)
            {
                throw new InvalidOperationException(Warnings.NoTransactionToPost);
            }

            if (details.Count().Equals(0))
            {
                throw new InvalidOperationException(Warnings.NoTransactionToPost);
            }

            string detail = CreateOpeningStockParameter(details);
            string sql = string.Format(CultureInfo.InvariantCulture,
                "SELECT * FROM transactions.post_opening_inventory(@OfficeId::integer, @UserId::integer, @LoginId::bigint, @ValueDate::date, @ReferenceNumber::national character varying(24), @StatementReference::text, ARRAY[{0}])",
                detail);

            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@LoginId", loginId);
                command.Parameters.AddWithValue("@ValueDate", valueDate);
                command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                command.Parameters.AddWithValue("@StatementReference", statementReference);


                command.Parameters.AddRange(AddOpeningStockParamter(details).ToArray());

                long tranId = Conversion.TryCastLong(DbOperation.GetScalarValue(catalog, command));
                return tranId;
            }
        }

        private static IEnumerable<NpgsqlParameter> AddOpeningStockParamter(Collection<OpeningStockType> details)
        {
            Collection<NpgsqlParameter> collection = new Collection<NpgsqlParameter>();

            if (details != null)
            {
                for (int i = 0; i < details.Count; i++)
                {
                    collection.Add(new NpgsqlParameter("@StoreName" + i, details[i].StoreName));
                    collection.Add(new NpgsqlParameter("@ItemCode" + i, details[i].ItemCode));
                    collection.Add(new NpgsqlParameter("@Quantity" + i, details[i].Quantity));
                    collection.Add(new NpgsqlParameter("@UnitName" + i, details[i].UnitName));
                    collection.Add(new NpgsqlParameter("@Amount" + i, details[i].Amount));
                }
            }

            return collection;
        }

        public static string CreateOpeningStockParameter(Collection<OpeningStockType> details)
        {
            if (details == null)
            {
                return "NULL::transactions.opening_stock_type";
            }

            Collection<string> detailCollection = new Collection<string>();
            for (int i = 0; i < details.Count; i++)
            {
                detailCollection.Add(string.Format(CultureInfo.InvariantCulture,
                    "ROW(@StoreName{0}, @ItemCode{0}, @Quantity{0}, @UnitName{0},@Amount{0})::transactions.opening_stock_type",
                    i.ToString(CultureInfo.InvariantCulture)));
            }

            return string.Join(",", detailCollection);
        }
    }
}