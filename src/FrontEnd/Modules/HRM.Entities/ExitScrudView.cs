// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.exit_scrud_view")]
    [ExplicitColumns]
    public sealed class ExitScrudView : PetaPocoDB.Record<ExitScrudView>, IPoco
    {
        [Column("exit_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ExitId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeId { get; set; }

        [Column("employee")]
        [ColumnDbType("text", 0, true, "")]
        public string Employee { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Reason { get; set; }

        [Column("forward_to")]
        [ColumnDbType("text", 0, true, "")]
        public string ForwardTo { get; set; }

        [Column("employment_status")]
        [ColumnDbType("text", 0, true, "")]
        public string EmploymentStatus { get; set; }

        [Column("exit_type")]
        [ColumnDbType("text", 0, true, "")]
        public string ExitType { get; set; }

        [Column("details")]
        [ColumnDbType("text", 0, true, "")]
        public string Details { get; set; }

        [Column("exit_interview_details")]
        [ColumnDbType("text", 0, true, "")]
        public string ExitInterviewDetails { get; set; }
    }
}