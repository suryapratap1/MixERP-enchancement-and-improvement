// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("pay_grade_id", autoIncrement = true)]
    [TableName("hrm.pay_grades")]
    [ExplicitColumns]
    public sealed class PayGrade : PetaPocoDB.Record<PayGrade>, IPoco
    {
        [Column("pay_grade_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.pay_grades_pay_grade_id_seq'::regclass)")]
        public int PayGradeId { get; set; }

        [Column("pay_grade_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string PayGradeCode { get; set; }

        [Column("pay_grade_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string PayGradeName { get; set; }

        [Column("minimum_salary")]
        [ColumnDbType("numeric", 1572868, false, "")]
        public decimal MinimumSalary { get; set; }

        [Column("maximum_salary")]
        [ColumnDbType("numeric", 1572869, false, "")]
        public decimal MaximumSalary { get; set; }

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