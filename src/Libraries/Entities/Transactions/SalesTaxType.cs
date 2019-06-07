using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.sales_tax_type")]
    [ExplicitColumns]
    public sealed class SalesTaxType : PetaPocoDB.Record<SalesTaxType>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")]
        public int Id { get; set; }

        [Column("sales_tax_detail_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SalesTaxDetailId { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SalesTaxId { get; set; }

        [Column("sales_tax_detail_code")]
        [ColumnDbType("text", 0, false, "")]
        public string SalesTaxDetailCode { get; set; }

        [Column("sales_tax_detail_name")]
        [ColumnDbType("text", 0, false, "")]
        public string SalesTaxDetailName { get; set; }

        [Column("is_use_tax")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool IsUseTax { get; set; }

        [Column("account_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int AccountId { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int Quantity { get; set; }

        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Discount { get; set; }

        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal ShippingCharge { get; set; }

        [Column("taxable_amount")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal TaxableAmount { get; set; }

        [Column("state_sales_tax_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int CountySalesTaxId { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict2", 0, false, "")]
        public decimal Rate { get; set; }

        [Column("base_amount_type")]
        [ColumnDbType("text", 0, false, "")]
        public string BaseAmountType { get; set; }

        [Column("rate_type")]
        [ColumnDbType("text", 0, false, "")]
        public string RateType { get; set; }

        [Column("rounding_type")]
        [ColumnDbType("text", 0, false, "")]
        public string RoundingType { get; set; }

        [Column("rounding_places")]
        [ColumnDbType("integer", 0, false, "")]
        public int RoundingPlaces { get; set; }

        [Column("tax")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Tax { get; set; }
    }
}