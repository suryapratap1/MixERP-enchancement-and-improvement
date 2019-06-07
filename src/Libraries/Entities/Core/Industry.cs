// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("industry_id", autoIncrement = true)]
    [TableName("core.industries")]
    [ExplicitColumns]
    public sealed class Industry : PetaPocoDB.Record<Industry>, IPoco
    {
        [Column("industry_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.industries_industry_id_seq'::regclass)")]
        public int IndustryId { get; set; }

        [Column("industry_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string IndustryName { get; set; }

        [Column("parent_industry_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ParentIndustryId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}