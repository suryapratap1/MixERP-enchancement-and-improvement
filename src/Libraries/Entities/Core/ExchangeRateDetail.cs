// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("exchange_rate_detail_id", autoIncrement = true)]
    [TableName("core.exchange_rate_details")]
    [ExplicitColumns]
    public sealed class ExchangeRateDetail : PetaPocoDB.Record<ExchangeRateDetail>, IPoco
    {
        [Column("exchange_rate_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.exchange_rate_details_exchange_rate_detail_id_seq'::regclass)")]
        public long ExchangeRateDetailId { get; set; }

        [Column("exchange_rate_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long ExchangeRateId { get; set; }

        [Column("local_currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string LocalCurrencyCode { get; set; }

        [Column("foreign_currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string ForeignCurrencyCode { get; set; }

        [Column("unit")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int Unit { get; set; }

        [Column("exchange_rate")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal ExchangeRate { get; set; }
    }
}