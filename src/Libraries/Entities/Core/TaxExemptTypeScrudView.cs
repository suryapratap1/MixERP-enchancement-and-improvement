// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.tax_exempt_type_scrud_view")]
    [ExplicitColumns]
    public sealed class TaxExemptTypeScrudView : PetaPocoDB.Record<TaxExemptTypeScrudView>, IPoco
    {
        [Column("tax_exempt_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TaxExemptTypeId { get; set; }

        [Column("tax_exempt_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string TaxExemptTypeCode { get; set; }

        [Column("tax_exempt_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string TaxExemptTypeName { get; set; }
    }
}