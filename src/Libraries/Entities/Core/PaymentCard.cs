// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("payment_card_id", autoIncrement = true)]
    [TableName("core.payment_cards")]
    [ExplicitColumns]
    public sealed class PaymentCard : PetaPocoDB.Record<PaymentCard>, IPoco
    {
        [Column("payment_card_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.payment_cards_payment_card_id_seq'::regclass)")]
        public int PaymentCardId { get; set; }

        [Column("payment_card_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string PaymentCardCode { get; set; }

        [Column("payment_card_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string PaymentCardName { get; set; }

        [Column("card_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CardTypeId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}