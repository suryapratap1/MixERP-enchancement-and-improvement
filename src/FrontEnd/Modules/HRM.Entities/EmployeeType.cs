// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("employee_type_id", autoIncrement = true)]
    [TableName("hrm.employee_types")]
    [ExplicitColumns]
    public sealed class EmployeeType : PetaPocoDB.Record<EmployeeType>, IPoco
    {
        [Column("employee_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.employee_types_employee_type_id_seq'::regclass)")]
        public int EmployeeTypeId { get; set; }

        [Column("employee_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string EmployeeTypeCode { get; set; }

        [Column("employee_type_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string EmployeeTypeName { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long AccountId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}