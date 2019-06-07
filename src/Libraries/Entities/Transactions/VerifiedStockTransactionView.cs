using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.verified_stock_transaction_view")]
    [ExplicitColumns]
    public sealed class VerifiedStockTransactionView : PetaPocoDB.Record<VerifiedStockTransactionView>, IPoco
    {
        [Column("transaction_master_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("stock_master_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long StockMasterId { get; set; }

        [Column("stock_detail_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long StockDetailId { get; set; }

        [Column("book")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Book { get; set; }

        [Column("transaction_counter")]
        [ColumnDbType("integer", 0, false, "")]
        public int TransactionCounter { get; set; }

        [Column("transaction_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string TransactionCode { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime TransactionTs { get; set; }

        [Column("login_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long LoginId { get; set; }

        [Column("user_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UserId { get; set; }

        [Column("sys_user_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SysUserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("cost_center_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int CostCenterId { get; set; }

        [Column("reference_number")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }

        [Column("last_verified_on")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int VerifiedByUserId { get; set; }

        [Column("verification_status_id")]
        [ColumnDbType("smallint", 0, false, "")]
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")]
        [ColumnDbType("character varying", 0, false, "")]
        public string VerificationReason { get; set; }

        [Column("party_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long PartyId { get; set; }

        [Column("country_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int CountryId { get; set; }

        [Column("state_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int StateId { get; set; }

        [Column("salesperson_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SalespersonId { get; set; }

        [Column("price_type_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int PriceTypeId { get; set; }

        [Column("is_credit")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool IsCredit { get; set; }

        [Column("shipper_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ShipperId { get; set; }

        [Column("shipping_address_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long ShippingAddressId { get; set; }

        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal ShippingCharge { get; set; }

        [Column("stock_master_store_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int StockMasterStoreId { get; set; }

        [Column("cash_repository_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int CashRepositoryId { get; set; }

        [Column("tran_type")]
        [ColumnDbType("transaction_type", 0, false, "")]
        public string TranType { get; set; }

        [Column("store_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int StoreId { get; set; }

        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer", 0, false, "")]
        public int Quantity { get; set; }

        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UnitId { get; set; }

        [Column("base_quantity")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int BaseUnitId { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Discount { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SalesTaxId { get; set; }

        [Column("tax")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Tax { get; set; }

        [Column("amount")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Amount { get; set; }
    }
}