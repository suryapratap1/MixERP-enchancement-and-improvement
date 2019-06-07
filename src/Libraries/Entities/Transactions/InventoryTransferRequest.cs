// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("inventory_transfer_request_id", autoIncrement = true)]
    [TableName("transactions.inventory_transfer_requests")]
    [ExplicitColumns]
    public sealed class InventoryTransferRequest : PetaPocoDB.Record<InventoryTransferRequest>, IPoco
    {
        [Column("inventory_transfer_request_id")]
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_requests_inventory_transfer_request_id_seq'::regclass)")]
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

        [Column("store_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int StoreId { get; set; }

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

        [Column("authorization_status_id")]
        [ColumnDbType("int2", 0, false, "0")]
        public short AuthorizationStatusId { get; set; }

        [Column("authorized_by_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuthorizedByUserId { get; set; }

        [Column("authorized_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuthorizedOn { get; set; }

        [Column("authorization_reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AuthorizationReason { get; set; }

        [Column("received")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Received { get; set; }

        [Column("received_by_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ReceivedByUserId { get; set; }

        [Column("received_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? ReceivedOn { get; set; }

        [Column("delivered")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Delivered { get; set; }

        [Column("delivered_by_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? DeliveredByUserId { get; set; }

        [Column("delivered_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? DeliveredOn { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}