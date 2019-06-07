// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.currency_scrud_view")]
    [ExplicitColumns]
    public sealed class CurrencyScrudView : PetaPocoDB.Record<CurrencyScrudView>, IPoco
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
    }
}