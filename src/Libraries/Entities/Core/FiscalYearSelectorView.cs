// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.fiscal_year_selector_view")]
    [ExplicitColumns]
    public sealed class FiscalYearSelectorView : PetaPocoDB.Record<FiscalYearSelectorView>, IPoco
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

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}