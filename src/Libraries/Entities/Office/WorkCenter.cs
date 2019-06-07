// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("work_center_id", autoIncrement = true)]
    [TableName("office.work_centers")]
    [ExplicitColumns]
    public sealed class WorkCenter : PetaPocoDB.Record<WorkCenter>, IPoco
    {
        [Column("work_center_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.work_centers_work_center_id_seq'::regclass)")]
        public int WorkCenterId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("work_center_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string WorkCenterCode { get; set; }

        [Column("work_center_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string WorkCenterName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}