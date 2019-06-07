// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.item_type_scrud_view")]
    [ExplicitColumns]
    public sealed class ItemTypeScrudView : PetaPocoDB.Record<ItemTypeScrudView>, IPoco
    {
        [Column("item_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemTypeId { get; set; }

        [Column("item_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ItemTypeCode { get; set; }

        [Column("item_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ItemTypeName { get; set; }
    }
}