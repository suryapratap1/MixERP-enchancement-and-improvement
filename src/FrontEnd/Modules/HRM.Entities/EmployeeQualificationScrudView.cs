// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.employee_qualification_scrud_view")]
    [ExplicitColumns]
    public sealed class EmployeeQualificationScrudView : PetaPocoDB.Record<EmployeeQualificationScrudView>, IPoco
    {
        [Column("employee_qualification_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? EmployeeQualificationId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeId { get; set; }

        [Column("employee_name")]
        [ColumnDbType("varchar", 160, true, "")]
        public string EmployeeName { get; set; }

        [Column("education_level_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string EducationLevelName { get; set; }

        [Column("institution")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Institution { get; set; }

        [Column("majors")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Majors { get; set; }

        [Column("total_years")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TotalYears { get; set; }

        [Column("score")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? Score { get; set; }

        [Column("started_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? StartedOn { get; set; }

        [Column("completed_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? CompletedOn { get; set; }
    }
}