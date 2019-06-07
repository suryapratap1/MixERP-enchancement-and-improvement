// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.variant_scrud_view")]
    [ExplicitColumns]
    public sealed class VariantScrudView : PetaPocoDB.Record<VariantScrudView>, IPoco
    {
        [Column("variant_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? VariantId { get; set; }

        [Column("variant_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string VariantCode { get; set; }

        [Column("variant_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string VariantName { get; set; }

        [Column("attribute")]
        [ColumnDbType("text", 0, true, "")]
        public string Attribute { get; set; }

        [Column("attribute_value")]
        [ColumnDbType("varchar", 200, true, "")]
        public string AttributeValue { get; set; }
    }
}