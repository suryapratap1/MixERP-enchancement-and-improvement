// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("currency_code", autoIncrement = false)]
    [TableName("core.currencies")]
    [ExplicitColumns]
    public sealed class Currency : PetaPocoDB.Record<Currency>, IPoco
    {
        [Column("currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CurrencySymbol { get; set; }

        [Column("currency_name")]
        [ColumnDbType("varchar", 48, false, "")]
        public string CurrencyName { get; set; }

        [Column("hundredth_name")]
        [ColumnDbType("varchar", 48, false, "")]
        public string HundredthName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}