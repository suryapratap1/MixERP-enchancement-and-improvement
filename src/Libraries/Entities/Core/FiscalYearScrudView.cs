// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.fiscal_year_scrud_view")]
    [ExplicitColumns]
    public sealed class FiscalYearScrudView : PetaPocoDB.Record<FiscalYearScrudView>, IPoco
    {
        [Column("fiscal_year_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string FiscalYearCode { get; set; }

        [Column("fiscal_year_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string FiscalYearName { get; set; }

        [Column("starts_from")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? StartsFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndsOn { get; set; }
    }
}