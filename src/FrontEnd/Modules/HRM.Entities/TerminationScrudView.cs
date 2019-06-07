// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.termination_scrud_view")]
    [ExplicitColumns]
    public sealed class TerminationScrudView : PetaPocoDB.Record<TerminationScrudView>, IPoco
    {
        [Column("termination_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TerminationId { get; set; }

        [Column("employee")]
        [ColumnDbType("text", 0, true, "")]
        public string Employee { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("notice_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? NoticeDate { get; set; }

        [Column("service_end_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ServiceEndDate { get; set; }

        [Column("forward_to")]
        [ColumnDbType("text", 0, true, "")]
        public string ForwardTo { get; set; }

        [Column("employment_status")]
        [ColumnDbType("text", 0, true, "")]
        public string EmploymentStatus { get; set; }

        [Column("reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Reason { get; set; }

        [Column("details")]
        [ColumnDbType("text", 0, true, "")]
        public string Details { get; set; }
    }
}