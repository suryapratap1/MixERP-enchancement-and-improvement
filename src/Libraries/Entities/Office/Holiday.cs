// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("holiday_id", autoIncrement = true)]
    [TableName("office.holidays")]
    [ExplicitColumns]
    public sealed class Holiday : PetaPocoDB.Record<Holiday>, IPoco
    {
        [Column("holiday_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.holidays_holiday_id_seq'::regclass)")]
        public int HolidayId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("holiday_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string HolidayName { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, true, "")]
        public string Description { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("occurs_on")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime OccursOn { get; set; }

        [Column("ends_on")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime EndsOn { get; set; }
    }
}