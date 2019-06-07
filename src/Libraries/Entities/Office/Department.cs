// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("department_id", autoIncrement = true)]
    [TableName("office.departments")]
    [ExplicitColumns]
    public sealed class Department : PetaPocoDB.Record<Department>, IPoco
    {
        [Column("department_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.departments_department_id_seq'::regclass)")]
        public int DepartmentId { get; set; }

        [Column("department_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string DepartmentCode { get; set; }

        [Column("department_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string DepartmentName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}