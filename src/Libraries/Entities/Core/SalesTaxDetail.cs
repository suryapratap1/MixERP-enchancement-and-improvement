// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("sales_tax_detail_id", autoIncrement = true)]
    [TableName("core.sales_tax_details")]
    [ExplicitColumns]
    public sealed class SalesTaxDetail : PetaPocoDB.Record<SalesTaxDetail>, IPoco
    {
        [Column("sales_tax_detail_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.sales_tax_details_sales_tax_detail_id_seq'::regclass)")]
        public int SalesTaxDetailId { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTaxId { get; set; }

        [Column("sales_tax_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTaxTypeId { get; set; }

        [Column("priority")]
        [ColumnDbType("int2", 0, false, "0")]
        public short Priority { get; set; }

        [Column("sales_tax_detail_code")]
        [ColumnDbType("varchar", 24, false, "")]
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string SalesTaxDetailName { get; set; }

        [Column("based_on_shipping_address")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool BasedOnShippingAddress { get; set; }

        [Column("check_nexus")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool CheckNexus { get; set; }

        [Column("applied_on_shipping_charge")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool AppliedOnShippingCharge { get; set; }

        [Column("state_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountySalesTaxId { get; set; }

        [Column("tax_rate_type_code")]
        [ColumnDbType("varchar", 12, false, "P")]
        public string TaxRateTypeCode { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, false, "")]
        public decimal Rate { get; set; }

        [Column("reporting_tax_authority_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ReportingTaxAuthorityId { get; set; }

        [Column("collecting_tax_authority_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CollectingTaxAuthorityId { get; set; }

        [Column("collecting_account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long CollectingAccountId { get; set; }

        [Column("use_tax_collecting_account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? UseTaxCollectingAccountId { get; set; }

        [Column("rounding_method_code")]
        [ColumnDbType("varchar", 4, true, "")]
        public string RoundingMethodCode { get; set; }

        [Column("rounding_decimal_places")]
        [ColumnDbType("integer_strict2", 0, false, "2")]
        public int RoundingDecimalPlaces { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}