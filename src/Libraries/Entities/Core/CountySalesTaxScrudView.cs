// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.county_sales_tax_scrud_view")]
    [ExplicitColumns]
    public sealed class CountySalesTaxScrudView : PetaPocoDB.Record<CountySalesTaxScrudView>, IPoco
    {
        [Column("county_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountySalesTaxId { get; set; }

        [Column("county_sales_tax_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CountySalesTaxCode { get; set; }

        [Column("county_sales_tax_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string CountySalesTaxName { get; set; }

        [Column("county")]
        [ColumnDbType("text", 0, true, "")]
        public string County { get; set; }

        [Column("entity_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string EntityName { get; set; }

        [Column("industry_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string IndustryName { get; set; }

        [Column("item_group")]
        [ColumnDbType("text", 0, true, "")]
        public string ItemGroup { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, true, "")]
        public decimal? Rate { get; set; }
    }
}