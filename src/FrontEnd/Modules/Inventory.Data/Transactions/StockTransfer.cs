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
    public static class StockTransfer
    {
        public static long Add(string catalog, int officeId, int userId, long loginId, DateTime valueDate,
            string referenceNumber, string statementReference, Collection<StockAdjustmentDetail> details)
        {
            string detailParameter = ParameterHelper.CreateStockTransferModelParameter(details);
            string sql = string.Format(CultureInfo.InvariantCulture,
                "SELECT * FROM transactions.post_stock_journal(@OfficeId::integer, @UserId::integer, @LoginId::bigint, @ValueDate::date, @ReferenceNumber::national character varying(24), @StatementReference::text, ARRAY[{0}]);",
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

        public static void Authorize(string catalog, int userId, long tranId)
        {
            const string sql =
                "UPDATE transactions.inventory_transfer_requests SET authorization_status_id = 2, authorized_by_user_id=@0, authorized_on=NOW() WHERE inventory_transfer_request_ID=@1";

            Factory.NonQuery(catalog, sql, userId, tranId);
        }

        public static void Reject(string catalog, int userId, long tranId)
        {
            const string sql =
                "UPDATE transactions.inventory_transfer_requests SET authorization_status_id = -3, authorized_by_user_id=@0, authorized_on=NOW() WHERE inventory_transfer_request_ID=@1";

            Factory.NonQuery(catalog, sql, userId, tranId);
        }
    }
}