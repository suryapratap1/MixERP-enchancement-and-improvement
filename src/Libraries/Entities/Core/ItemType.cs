// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("item_type_id", autoIncrement = true)]
    [TableName("core.item_types")]
    [ExplicitColumns]
    public sealed class ItemType : PetaPocoDB.Record<ItemType>, IPoco
    {
        [Column("item_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.item_types_item_type_id_seq'::regclass)")]
        public int ItemTypeId { get; set; }

        [Column("item_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string ItemTypeCode { get; set; }

        [Column("item_type_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string ItemTypeName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("is_component")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool IsComponent { get; set; }
    }
}