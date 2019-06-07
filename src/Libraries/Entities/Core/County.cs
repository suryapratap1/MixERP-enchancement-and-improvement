// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("county_id", autoIncrement = true)]
    [TableName("core.counties")]
    [ExplicitColumns]
    public sealed class County : PetaPocoDB.Record<County>, IPoco
    {
        [Column("county_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.counties_county_id_seq'::regclass)")]
        public int CountyId { get; set; }

        [Column("county_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CountyCode { get; set; }

        [Column("county_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string CountyName { get; set; }

        [Column("state_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int StateId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}