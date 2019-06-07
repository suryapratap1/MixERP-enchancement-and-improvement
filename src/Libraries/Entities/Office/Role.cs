// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("role_id", autoIncrement = true)]
    [TableName("office.roles")]
    [ExplicitColumns]
    public sealed class Role : PetaPocoDB.Record<Role>, IPoco
    {
        [Column("role_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.roles_role_id_seq'::regclass)")]
        public int RoleId { get; set; }

        [Column("role_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string RoleCode { get; set; }

        [Column("role_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string RoleName { get; set; }

        [Column("is_admin")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsAdmin { get; set; }

        [Column("is_system")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsSystem { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}