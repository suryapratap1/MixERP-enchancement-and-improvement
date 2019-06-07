// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("nationality_code", autoIncrement = false)]
    [TableName("core.nationalities")]
    [ExplicitColumns]
    public sealed class Nationality : PetaPocoDB.Record<Nationality>, IPoco
    {
        [Column("nationality_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string NationalityCode { get; set; }

        [Column("nationality_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string NationalityName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}