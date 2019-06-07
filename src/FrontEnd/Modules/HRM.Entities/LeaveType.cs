// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("leave_type_id", autoIncrement = true)]
    [TableName("hrm.leave_types")]
    [ExplicitColumns]
    public sealed class LeaveType : PetaPocoDB.Record<LeaveType>, IPoco
    {
        [Column("leave_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.leave_types_leave_type_id_seq'::regclass)")]
        public int LeaveTypeId { get; set; }

        [Column("leave_type_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string LeaveTypeCode { get; set; }

        [Column("leave_type_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string LeaveTypeName { get; set; }

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