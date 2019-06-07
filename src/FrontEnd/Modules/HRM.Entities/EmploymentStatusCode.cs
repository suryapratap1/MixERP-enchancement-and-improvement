// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("employment_status_code_id", autoIncrement = false)]
    [TableName("hrm.employment_status_codes")]
    [ExplicitColumns]
    public sealed class EmploymentStatusCode : PetaPocoDB.Record<EmploymentStatusCode>, IPoco
    {
        [Column("employment_status_code_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmploymentStatusCodeId { get; set; }

        [Column("status_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string StatusCode { get; set; }

        [Column("status_code_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string StatusCodeName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}