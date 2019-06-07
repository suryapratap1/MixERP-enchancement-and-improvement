// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.compound_item_selector_view")]
    [ExplicitColumns]
    public sealed class CompoundItemSelectorView : PetaPocoDB.Record<CompoundItemSelectorView>, IPoco
    {
        [Column("compound_item_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CompoundItemId { get; set; }

        [Column("compound_item_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CompoundItemCode { get; set; }

        [Column("compound_item_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string CompoundItemName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}