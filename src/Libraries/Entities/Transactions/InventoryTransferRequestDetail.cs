// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("inventory_transfer_request_detail_id", autoIncrement = true)]
    [TableName("transactions.inventory_transfer_request_details")]
    [ExplicitColumns]
    public sealed class InventoryTransferRequestDetail : PetaPocoDB.Record<InventoryTransferRequestDetail>, IPoco
    {
        [Column("inventory_transfer_request_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('inventory_transfer_request_de_inventory_transfer_request_de_seq'::regclass)")]
        public long InventoryTransferRequestDetailId { get; set; }

        [Column("inventory_transfer_request_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long InventoryTransferRequestId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ItemId { get; set; }

        [Column("quantity")]
        [ColumnDbType("int4", 0, false, "")]
        public int Quantity { get; set; }

        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UnitId { get; set; }

        [Column("base_quantity")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int BaseUnitId { get; set; }
    }
}