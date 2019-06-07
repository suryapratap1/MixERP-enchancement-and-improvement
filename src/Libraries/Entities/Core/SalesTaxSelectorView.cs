// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.sales_tax_selector_view")]
    [ExplicitColumns]
    public sealed class SalesTaxSelectorView : PetaPocoDB.Record<SalesTaxSelectorView>, IPoco
    {
        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxId { get; set; }

        [Column("tax_master_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TaxMasterId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("sales_tax_code")]
        [ColumnDbType("varchar", 24, true, "")]
        public string SalesTaxCode { get; set; }

        [Column("sales_tax_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SalesTaxName { get; set; }

        [Column("is_exemption")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsExemption { get; set; }

        [Column("tax_base_amount_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string TaxBaseAmountTypeCode { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, true, "")]
        public decimal? Rate { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}