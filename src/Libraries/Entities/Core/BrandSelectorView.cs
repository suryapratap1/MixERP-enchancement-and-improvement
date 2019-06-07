// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.brand_selector_view")]
    [ExplicitColumns]
    public sealed class BrandSelectorView : PetaPocoDB.Record<BrandSelectorView>, IPoco
    {
        [Column("brand_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? BrandId { get; set; }

        [Column("brand_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string BrandCode { get; set; }

        [Column("brand_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string BrandName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}