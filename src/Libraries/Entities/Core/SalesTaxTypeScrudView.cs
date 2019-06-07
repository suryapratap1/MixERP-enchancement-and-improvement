// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.sales_tax_type_scrud_view")]
    [ExplicitColumns]
    public sealed class SalesTaxTypeScrudView : PetaPocoDB.Record<SalesTaxTypeScrudView>, IPoco
    {
        [Column("sales_tax_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxTypeId { get; set; }

        [Column("sales_tax_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string SalesTaxTypeCode { get; set; }

        [Column("sales_tax_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SalesTaxTypeName { get; set; }

        [Column("is_vat")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsVat { get; set; }
    }
}