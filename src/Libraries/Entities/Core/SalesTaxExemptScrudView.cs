// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.sales_tax_exempt_scrud_view")]
    [ExplicitColumns]
    public sealed class SalesTaxExemptScrudView : PetaPocoDB.Record<SalesTaxExemptScrudView>, IPoco
    {
        [Column("sales_tax_exempt_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxExemptId { get; set; }

        [Column("tax_master")]
        [ColumnDbType("text", 0, true, "")]
        public string TaxMaster { get; set; }

        [Column("sales_tax_exempt_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string SalesTaxExemptCode { get; set; }

        [Column("sales_tax_exempt_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string SalesTaxExemptName { get; set; }

        [Column("tax_exempt_type")]
        [ColumnDbType("text", 0, true, "")]
        public string TaxExemptType { get; set; }

        [Column("store")]
        [ColumnDbType("text", 0, true, "")]
        public string Store { get; set; }

        [Column("sales_tax")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTax { get; set; }

        [Column("valid_from")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValidFrom { get; set; }

        [Column("valid_till")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValidTill { get; set; }

        [Column("price_from")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? PriceFrom { get; set; }

        [Column("price_to")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? PriceTo { get; set; }
    }
}