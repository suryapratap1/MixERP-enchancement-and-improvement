// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.payment_card_scrud_view")]
    [ExplicitColumns]
    public sealed class PaymentCardScrudView : PetaPocoDB.Record<PaymentCardScrudView>, IPoco
    {
        [Column("payment_card_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PaymentCardId { get; set; }

        [Column("payment_card_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string PaymentCardCode { get; set; }

        [Column("payment_card_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string PaymentCardName { get; set; }

        [Column("card_type")]
        [ColumnDbType("text", 0, true, "")]
        public string CardType { get; set; }
    }
}