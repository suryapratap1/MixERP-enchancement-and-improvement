// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.compound_item_scrud_view")]
    [ExplicitColumns]
    public sealed class CompoundItemScrudView : PetaPocoDB.Record<CompoundItemScrudView>, IPoco
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
    }
}