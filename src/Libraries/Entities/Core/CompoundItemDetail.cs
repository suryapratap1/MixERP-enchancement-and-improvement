// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("compound_item_detail_id", autoIncrement = true)]
    [TableName("core.compound_item_details")]
    [ExplicitColumns]
    public sealed class CompoundItemDetail : PetaPocoDB.Record<CompoundItemDetail>, IPoco
    {
        [Column("compound_item_detail_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.compound_item_details_compound_item_detail_id_seq'::regclass)")]
        public int CompoundItemDetailId { get; set; }

        [Column("compound_item_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CompoundItemId { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ItemId { get; set; }

        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UnitId { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int Quantity { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal Discount { get; set; }
    }
}