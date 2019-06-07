// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("employee_identification_detail_id", autoIncrement = true)]
    [TableName("hrm.employee_identification_details")]
    [ExplicitColumns]
    public sealed class EmployeeIdentificationDetail : PetaPocoDB.Record<EmployeeIdentificationDetail>, IPoco
    {
        [Column("employee_identification_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.employee_identification_detai_employee_identification_detai_seq'::regclass)")]
        public long EmployeeIdentificationDetailId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("identification_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string IdentificationTypeCode { get; set; }

        [Column("identification_number")]
        [ColumnDbType("varchar", 128, false, "")]
        public string IdentificationNumber { get; set; }

        [Column("expires_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ExpiresOn { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}