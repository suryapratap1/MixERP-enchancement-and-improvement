// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.work_center_view")]
    [ExplicitColumns]
    public sealed class WorkCenterView : PetaPocoDB.Record<WorkCenterView>, IPoco
    {
        [Column("work_center_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? WorkCenterId { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, true, "")]
        public string Office { get; set; }

        [Column("work_center_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string WorkCenterCode { get; set; }

        [Column("work_center_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string WorkCenterName { get; set; }
    }
}