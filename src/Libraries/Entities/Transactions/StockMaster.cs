// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("stock_master_id", autoIncrement = true)]
    [TableName("transactions.stock_master")]
    [ExplicitColumns]
    public sealed class StockMaster : PetaPocoDB.Record<StockMaster>, IPoco
    {
        [Column("stock_master_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_master_stock_master_id_seq'::regclass)")]
        public long StockMasterId { get; set; }

        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PartyId { get; set; }

        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalespersonId { get; set; }

        [Column("price_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PriceTypeId { get; set; }

        [Column("is_credit")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsCredit { get; set; }

        [Column("payment_term_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PaymentTermId { get; set; }

        [Column("shipper_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ShipperId { get; set; }

        [Column("shipping_address_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ShippingAddressId { get; set; }

        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal ShippingCharge { get; set; }

        [Column("store_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StoreId { get; set; }

        [Column("non_taxable")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool NonTaxable { get; set; }

        [Column("cash_repository_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashRepositoryId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("credit_settled")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? CreditSettled { get; set; }
    }
}