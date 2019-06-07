// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.sales_tax_exempt_detail_scrud_view")]
    [ExplicitColumns]
    public sealed class SalesTaxExemptDetailScrudView : PetaPocoDB.Record<SalesTaxExemptDetailScrudView>, IPoco
    {
        [Column("sales_tax_exempt_detail_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxExemptDetailId { get; set; }

        [Column("sales_tax_exempt")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTaxExempt { get; set; }

        [Column("entity_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string EntityName { get; set; }

        [Column("industry_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string IndustryName { get; set; }

        [Column("party")]
        [ColumnDbType("text", 0, true, "")]
        public string Party { get; set; }

        [Column("party_type")]
        [ColumnDbType("text", 0, true, "")]
        public string PartyType { get; set; }

        [Column("item")]
        [ColumnDbType("text", 0, true, "")]
        public string Item { get; set; }

        [Column("item_group")]
        [ColumnDbType("text", 0, true, "")]
        public string ItemGroup { get; set; }
    }
}