// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("sales_tax_exempt_detail_id", autoIncrement = true)]
    [TableName("core.sales_tax_exempt_details")]
    [ExplicitColumns]
    public sealed class SalesTaxExemptDetail : PetaPocoDB.Record<SalesTaxExemptDetail>, IPoco
    {
        [Column("sales_tax_exempt_detail_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.sales_tax_exempt_details_sales_tax_exempt_detail_id_seq'::regclass)")]
        public int SalesTaxExemptDetailId { get; set; }

        [Column("sales_tax_exempt_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTaxExemptId { get; set; }

        [Column("entity_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EntityId { get; set; }

        [Column("industry_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? IndustryId { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PartyId { get; set; }

        [Column("party_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PartyTypeId { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemId { get; set; }

        [Column("item_group_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemGroupId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}