// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.office_hour_scrud_view")]
    [ExplicitColumns]
    public sealed class OfficeHourScrudView : PetaPocoDB.Record<OfficeHourScrudView>, IPoco
    {
        [Column("office_hour_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeHourId { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, true, "")]
        public string Office { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("shift")]
        [ColumnDbType("text", 0, true, "")]
        public string Shift { get; set; }

        [Column("week_day")]
        [ColumnDbType("text", 0, true, "")]
        public string WeekDay { get; set; }

        [Column("begins_from")]
        [ColumnDbType("time", 0, true, "")]
        public DateTime? BeginsFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("time", 0, true, "")]
        public DateTime? EndsOn { get; set; }
    }
}