// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.resignation_verification_scrud_view")]
    [ExplicitColumns]
    public sealed class ResignationVerificationScrudView : PetaPocoDB.Record<ResignationVerificationScrudView>, IPoco
    {
        [Column("resignation_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ResignationId { get; set; }

        [Column("entered_by")]
        [ColumnDbType("varchar", 50, true, "")]
        public string EnteredBy { get; set; }

        [Column("notice_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? NoticeDate { get; set; }

        [Column("desired_resign_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? DesiredResignDate { get; set; }

        [Column("employee")]
        [ColumnDbType("text", 0, true, "")]
        public string Employee { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("forward_to")]
        [ColumnDbType("text", 0, true, "")]
        public string ForwardTo { get; set; }

        [Column("reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Reason { get; set; }
    }
}