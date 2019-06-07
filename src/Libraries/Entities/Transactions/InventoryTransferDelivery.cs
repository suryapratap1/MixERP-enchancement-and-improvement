// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("inventory_transfer_delivery_id", autoIncrement = true)]
    [TableName("transactions.inventory_transfer_deliveries")]
    [ExplicitColumns]
    public sealed class InventoryTransferDelivery : PetaPocoDB.Record<InventoryTransferDelivery>, IPoco
    {
        [Column("inventory_transfer_delivery_id")]
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_deliveries_inventory_transfer_delivery_i_seq'::regclass)")]
        public long InventoryTransferDeliveryId { get; set; }

        [Column("inventory_transfer_request_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long InventoryTransferRequestId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("login_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long LoginId { get; set; }

        [Column("source_store_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SourceStoreId { get; set; }

        [Column("destination_store_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int DestinationStoreId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? TransactionTs { get; set; }

        [Column("reference_number")]
        [ColumnDbType("varchar", 24, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}