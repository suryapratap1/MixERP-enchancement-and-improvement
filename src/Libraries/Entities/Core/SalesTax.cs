// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("sales_tax_id", autoIncrement = true)]
    [TableName("core.sales_taxes")]
    [ExplicitColumns]
    public sealed class SalesTax : PetaPocoDB.Record<SalesTax>, IPoco
    {
        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.sales_taxes_sales_tax_id_seq'::regclass)")]
        public int SalesTaxId { get; set; }

        [Column("tax_master_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int TaxMasterId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("sales_tax_code")]
        [ColumnDbType("varchar", 24, false, "")]
        public string SalesTaxCode { get; set; }

        [Column("sales_tax_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string SalesTaxName { get; set; }

        [Column("is_exemption")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsExemption { get; set; }

        [Column("tax_base_amount_type_code")]
        [ColumnDbType("varchar", 12, false, "P")]
        public string TaxBaseAmountTypeCode { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, false, "0")]
        public decimal Rate { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}