// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("exchange_rate_id", autoIncrement = true)]
    [TableName("core.exchange_rates")]
    [ExplicitColumns]
    public sealed class ExchangeRate : PetaPocoDB.Record<ExchangeRate>, IPoco
    {
        [Column("exchange_rate_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.exchange_rates_exchange_rate_id_seq'::regclass)")]
        public long ExchangeRateId { get; set; }

        [Column("updated_on")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime UpdatedOn { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("status")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool Status { get; set; }
    }
}