using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using MixERP.Net.Common;
using MixERP.Net.Core.Modules.Inventory.Data.Domains;
using MixERP.Net.Core.Modules.Inventory.Data.Helpers;
using MixERP.Net.DbFactory;
using MixERP.Net.Entities.Transactions.Models;
using Npgsql;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Transactions
{
    public static class StockTransferDelivery
    {
        public static IEnumerable<StockTransferDeliveryModel> GetModel(string catalog, long requestId)
        {
            const string sql = @"SELECT
                                    office.stores.store_name,
                                    core.items.item_code,
                                    core.items.item_name,
                                    core.units.unit_name,
                                    transactions.inventory_transfer_request_details.quantity
                                FROM transactions.inventory_transfer_requests
                                INNER JOIN transactions.inventory_transfer_request_details
                                ON transactions.inventory_transfer_requests.inventory_transfer_request_id = transactions.inventory_transfer_request_details.inventory_transfer_request_id
                                INNER JOIN office.stores
                                ON transactions.inventory_transfer_requests.store_id = office.stores.store_id
                                INNER JOIN core.items
                                ON transactions.inventory_transfer_request_details.item_id = core.items.item_id
                                INNER JOIN core.units
                                ON transactions.inventory_transfer_request_details.unit_id = core.units.unit_id
                                WHERE transactions.inventory_transfer_requests.inventory_transfer_request_id = @0;";

            return Factory.Get<StockTransferDeliveryModel>(catalog, sql, requestId);
        }

        public static long Add(string catalog, int officeId, int userId, long loginId, long requestId,
            DateTime valueDate, string referenceNumber, string statementReference, int shipperId, int sourceStoreId,
            Collection<StockAdjustmentDetail> details)
        {
            string detailParameter = ParameterHelper.CreateStockTransferModelParameter(details);
            string sql = string.Format(CultureInfo.InvariantCulture,
                "SELECT * FROM transactions.post_inventory_transfer_delivery(@OfficeId::integer, @UserId::integer, @LoginId::bigint, @RequestId::bigint, @ValueDate::date, @ReferenceNumber::national character varying(24), @StatementReference::text, @ShipperId, @SourceStoreId, ARRAY[{0}]);",
                detailParameter);

            using (NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@OfficeId", officeId);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@LoginId", loginId);
                command.Parameters.AddWithValue("@RequestId", requestId);
                command.Parameters.AddWithValue("@ValueDate", valueDate);
                command.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);
                command.Parameters.AddWithValue("@StatementReference", statementReference);
                command.Parameters.AddWithValue("@ShipperId", shipperId);
                command.Parameters.AddWithValue("@SourceStoreId", sourceStoreId);
                command.Parameters.AddRange(ParameterHelper.AddStockTransferModelParameter(details).ToArray());

                long tranId = Conversion.TryCastLong(DbOperation.GetScalarValue(catalog, command));
                return tranId;
            }
        }
    }
}