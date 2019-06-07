// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.sales_tax_detail_scrud_view")]
    [ExplicitColumns]
    public sealed class SalesTaxDetailScrudView : PetaPocoDB.Record<SalesTaxDetailScrudView>, IPoco
    {
        [Column("sales_tax_detail_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxDetailId { get; set; }

        [Column("sales_tax")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTax { get; set; }

        [Column("sales_tax_type")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTaxType { get; set; }

        [Column("priority")]
        [ColumnDbType("int2", 0, true, "")]
        public short? Priority { get; set; }

        [Column("sales_tax_detail_code")]
        [ColumnDbType("varchar", 24, true, "")]
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SalesTaxDetailName { get; set; }

        [Column("based_on_shipping_address")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? BasedOnShippingAddress { get; set; }

        [Column("check_nexus")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? CheckNexus { get; set; }

        [Column("applied_on_shipping_charge")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AppliedOnShippingCharge { get; set; }

        [Column("state_sales_tax")]
        [ColumnDbType("text", 0, true, "")]
        public string StateSalesTax { get; set; }

        [Column("county_sales_tax")]
        [ColumnDbType("text", 0, true, "")]
        public string CountySalesTax { get; set; }

        [Column("tax_rate_type")]
        [ColumnDbType("text", 0, true, "")]
        public string TaxRateType { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, true, "")]
        public decimal? Rate { get; set; }

        [Column("reporting_tax_authority")]
        [ColumnDbType("text", 0, true, "")]
        public string ReportingTaxAuthority { get; set; }

        [Column("collecting_tax_authority")]
        [ColumnDbType("text", 0, true, "")]
        public string CollectingTaxAuthority { get; set; }

        [Column("collecting_account")]
        [ColumnDbType("text", 0, true, "")]
        public string CollectingAccount { get; set; }

        [Column("use_tax_collecting_account")]
        [ColumnDbType("text", 0, true, "")]
        public string UseTaxCollectingAccount { get; set; }

        [Column("rounding_method")]
        [ColumnDbType("text", 0, true, "")]
        public string RoundingMethod { get; set; }

        [Column("rounding_decimal_places")]
        [ColumnDbType("integer_strict2", 0, true, "")]
        public int? RoundingDecimalPlaces { get; set; }
    }
}