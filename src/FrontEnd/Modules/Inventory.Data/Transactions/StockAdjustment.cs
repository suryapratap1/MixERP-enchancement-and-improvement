using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using MixERP.Net.Common;
using MixERP.Net.Core.Modules.Inventory.Data.Helpers;
using MixERP.Net.DbFactory;
using MixERP.Net.Entities.Transactions.Models;
using Npgsql;

namespace MixERP.Net.Core.Modules.Inventory.Data.Transactions
{
    public static class StockAdjustment
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate,
            string referenceNumber, string statementReference, Collection<StockAdjustmentDetail> details)
        {
            string detailParameter = ParameterHelper.CreateStockTransferModelParameter(details);
            string sql = string.Format(CultureInfo.InvariantCulture,
                "SELECT * FROM transactions.post_stock_adjustment(@OfficeId::integer, @UserId::integer, @LoginId::bigint, @ValueDate::date, @ReferenceNumber::national character varying(24), @StatementReference::text, ARRAY[{0}]);",
                detailParameter);

            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@LoginId", loginId);
                command.Parameters.AddWithValue("@ValueDate", valueDate);
                command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                command.Parameters.AddWithValue("@StatementReference", statementReference);
                command.Parameters.AddRange(ParameterHelper.AddStockTransferModelParameter(details).ToArray());

                long tranId = Conversion.TryCastLong(DbOperation.GetScalarValue(catalog, command));
                return tranId;
            }
        }
    }
}