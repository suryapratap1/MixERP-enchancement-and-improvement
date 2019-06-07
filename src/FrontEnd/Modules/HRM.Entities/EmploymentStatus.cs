// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("employment_status_id", autoIncrement = true)]
    [TableName("hrm.employment_statuses")]
    [ExplicitColumns]
    public sealed class EmploymentStatus : PetaPocoDB.Record<EmploymentStatus>, IPoco
    {
        [Column("employment_status_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.employment_statuses_employment_status_id_seq'::regclass)")]
        public int EmploymentStatusId { get; set; }

        [Column("employment_status_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string EmploymentStatusCode { get; set; }

        [Column("employment_status_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string EmploymentStatusName { get; set; }

        [Column("is_contract")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsContract { get; set; }

        [Column("default_employment_status_code_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int DefaultEmploymentStatusCodeId { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, true, "")]
        public string Description { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}