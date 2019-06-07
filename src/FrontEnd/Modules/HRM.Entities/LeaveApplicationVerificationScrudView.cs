// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.leave_application_verification_scrud_view")]
    [ExplicitColumns]
    public sealed class LeaveApplicationVerificationScrudView : PetaPocoDB.Record<LeaveApplicationVerificationScrudView>, IPoco
    {
        [Column("leave_application_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? LeaveApplicationId { get; set; }

        [Column("employee")]
        [ColumnDbType("text", 0, true, "")]
        public string Employee { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("leave_type")]
        [ColumnDbType("text", 0, true, "")]
        public string LeaveType { get; set; }

        [Column("entered_by")]
        [ColumnDbType("varchar", 50, true, "")]
        public string EnteredBy { get; set; }

        [Column("applied_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? AppliedOn { get; set; }

        [Column("reason")]
        [ColumnDbType("text", 0, true, "")]
        public string Reason { get; set; }

        [Column("start_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndDate { get; set; }
    }
}