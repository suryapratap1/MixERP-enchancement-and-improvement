// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("gender_code", autoIncrement = false)]
    [TableName("core.genders")]
    [ExplicitColumns]
    public sealed class Gender : PetaPocoDB.Record<Gender>, IPoco
    {
        [Column("gender_code")]
        [ColumnDbType("varchar", 4, false, "")]
        public string GenderCode { get; set; }

        [Column("gender_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string GenderName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}