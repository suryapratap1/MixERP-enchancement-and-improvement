// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("brand_id", autoIncrement = true)]
    [TableName("core.brands")]
    [ExplicitColumns]
    public sealed class Brand : PetaPocoDB.Record<Brand>, IPoco
    {
        [Column("brand_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.brands_brand_id_seq'::regclass)")]
        public int BrandId { get; set; }

        [Column("brand_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string BrandCode { get; set; }

        [Column("brand_name")]
        [ColumnDbType("varchar", 150, false, "")]
        public string BrandName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}