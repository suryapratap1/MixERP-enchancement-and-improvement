// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.currency_selector_view")]
    [ExplicitColumns]
    public sealed class CurrencySelectorView : PetaPocoDB.Record<CurrencySelectorView>, IPoco
    {
        [Column("currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CurrencySymbol { get; set; }

        [Column("currency_name")]
        [ColumnDbType("varchar", 48, true, "")]
        public string CurrencyName { get; set; }

        [Column("hundredth_name")]
        [ColumnDbType("varchar", 48, true, "")]
        public string HundredthName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}