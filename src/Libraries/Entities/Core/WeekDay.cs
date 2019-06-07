// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("week_day_id", autoIncrement = false)]
    [TableName("core.week_days")]
    [ExplicitColumns]
    public sealed class WeekDay : PetaPocoDB.Record<WeekDay>, IPoco
    {
        [Column("week_day_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int WeekDayId { get; set; }

        [Column("week_day_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string WeekDayCode { get; set; }

        [Column("week_day_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string WeekDayName { get; set; }
    }
}