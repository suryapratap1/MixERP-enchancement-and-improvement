// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("non_gl_stock_master_id", autoIncrement = true)]
    [TableName("transactions.non_gl_stock_master")]
    [ExplicitColumns]
    public sealed class NonGlStockMaster : PetaPocoDB.Record<NonGlStockMaster>, IPoco
    {
        [Column("non_gl_stock_master_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.non_gl_stock_master_non_gl_stock_master_id_seq'::regclass)")]
        public long NonGlStockMasterId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("book")]
        [ColumnDbType("varchar", 48, false, "")]
        public string Book { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long PartyId { get; set; }

        [Column("price_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PriceTypeId { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime TransactionTs { get; set; }

        [Column("login_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long LoginId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("reference_number")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("non_taxable")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool NonTaxable { get; set; }

        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalespersonId { get; set; }

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

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}