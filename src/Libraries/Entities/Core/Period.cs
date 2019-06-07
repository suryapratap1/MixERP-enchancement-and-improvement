using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.period")]
    [ExplicitColumns]
    public sealed class Period : PetaPocoDB.Record<Period>, IPoco
    {
        [Column("period_name")]
        [ColumnDbType("text", 0, false, "")]
        public string PeriodName { get; set; }

        [Column("date_from")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime DateFrom { get; set; }

        [Column("date_to")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime DateTo { get; set; }
    }
}