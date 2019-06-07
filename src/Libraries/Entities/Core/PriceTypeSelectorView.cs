// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.price_type_selector_view")]
    [ExplicitColumns]
    public sealed class PriceTypeSelectorView : PetaPocoDB.Record<PriceTypeSelectorView>, IPoco
    {
        [Column("price_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PriceTypeId { get; set; }

        [Column("price_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string PriceTypeCode { get; set; }

        [Column("price_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PriceTypeName { get; set; }
    }
}