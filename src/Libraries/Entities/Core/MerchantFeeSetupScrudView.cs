// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.merchant_fee_setup_scrud_view")]
    [ExplicitColumns]
    public sealed class MerchantFeeSetupScrudView : PetaPocoDB.Record<MerchantFeeSetupScrudView>, IPoco
    {
        [Column("merchant_fee_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? MerchantFeeSetupId { get; set; }

        [Column("merchant_account")]
        [ColumnDbType("text", 0, true, "")]
        public string MerchantAccount { get; set; }

        [Column("payment_card")]
        [ColumnDbType("text", 0, true, "")]
        public string PaymentCard { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict", 0, true, "")]
        public decimal? Rate { get; set; }

        [Column("customer_pays_fee")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? CustomerPaysFee { get; set; }

        [Column("account")]
        [ColumnDbType("text", 0, true, "")]
        public string Account { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("varchar", 128, true, "")]
        public string StatementReference { get; set; }
    }
}