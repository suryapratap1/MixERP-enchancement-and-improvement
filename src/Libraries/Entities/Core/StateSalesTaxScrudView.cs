// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.state_sales_tax_scrud_view")]
    [ExplicitColumns]
    public sealed class StateSalesTaxScrudView : PetaPocoDB.Record<StateSalesTaxScrudView>, IPoco
    {
        [Column("state_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StateSalesTaxId { get; set; }

        [Column("state_sales_tax_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string StateSalesTaxCode { get; set; }

        [Column("state_sales_tax_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string StateSalesTaxName { get; set; }

        [Column("state")]
        [ColumnDbType("text", 0, true, "")]
        public string State { get; set; }

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