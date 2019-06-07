// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.stock_transaction_view")]
    [ExplicitColumns]
    public sealed class StockTransactionView : PetaPocoDB.Record<StockTransactionView>, IPoco
    {
        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TransactionMasterId { get; set; }

        [Column("stock_master_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? StockMasterId { get; set; }

        [Column("stock_detail_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? StockDetailId { get; set; }

        [Column("book")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Book { get; set; }

        [Column("transaction_counter")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TransactionCounter { get; set; }

        [Column("transaction_code")]
        [ColumnDbType("varchar", 50, true, "")]
        public string TransactionCode { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValueDate { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? TransactionTs { get; set; }

        [Column("login_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? LoginId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("sys_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SysUserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("cost_center_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CostCenterId { get; set; }

        [Column("reference_number")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("last_verified_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")]
        [ColumnDbType("int2", 0, true, "")]
        public short? VerificationStatusId { get; set; }

        [Column("verification_reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string VerificationReason { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PartyId { get; set; }

        [Column("country_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountryId { get; set; }

        [Column("state_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StateId { get; set; }

        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalespersonId { get; set; }

        [Column("price_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PriceTypeId { get; set; }

        [Column("is_credit")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsCredit { get; set; }

        [Column("shipper_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ShipperId { get; set; }

        [Column("shipping_address_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ShippingAddressId { get; set; }

        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? ShippingCharge { get; set; }

        [Column("stock_master_store_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StockMasterStoreId { get; set; }

        [Column("cash_repository_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashRepositoryId { get; set; }

        [Column("tran_type")]
        [ColumnDbType("transaction_type", 0, true, "")]
        public string TranType { get; set; }

        [Column("store_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StoreId { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemId { get; set; }

        [Column("quantity")]
        [ColumnDbType("int4", 0, true, "")]
        public int? Quantity { get; set; }

        [Column("unit_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UnitId { get; set; }

        [Column("base_quantity")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? BaseQuantity { get; set; }

        [Column("base_unit_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? BaseUnitId { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? Price { get; set; }

        [Column("discount")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? Discount { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxId { get; set; }

        [Column("tax")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? Tax { get; set; }

        [Column("amount")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? Amount { get; set; }
    }
}