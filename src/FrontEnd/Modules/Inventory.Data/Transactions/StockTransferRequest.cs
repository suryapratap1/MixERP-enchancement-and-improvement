using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using MixERP.Net.Common;
using MixERP.Net.Core.Modules.Inventory.Data.Helpers;
using MixERP.Net.DbFactory;
using MixERP.Net.Entities.Transactions.Models;
using Npgsql;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Transactions
{
    public static class StockTransferRequest
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate,
            string referenceNumber, string statementReference, Collection<StockAdjustmentDetail> details)
        {
            string detailParameter = ParameterHelper.CreateStockTransferModelParameter(details);
            string sql = string.Format(CultureInfo.InvariantCulture,
                "SELECT * FROM transactions.post_inventory_transfer_request(@OfficeId::integer, @UserId::integer, @LoginId::bigint, @ValueDate::date, @ReferenceNumber::national character varying(24), @StatementReference::text, ARRAY[{0}]);",
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

        public static bool IsValidStockTransferRequestId(string catalog, long requestId)
        {
            const string sql = @"SELECT COUNT(*) 
                                FROM transactions.inventory_transfer_requests 
                                WHERE inventory_transfer_request_id = @0 
                                AND authorization_status_id > 0 
                                AND NOT delivered 
                                AND NOT received;";
            long count = Factory.Scalar<long>(catalog, sql, requestId);

            return count.Equals(1);
        }
    }
}