// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_merge_model")]
    [ExplicitColumns]
    public sealed class DbGetMergeModelResult : PetaPocoDB.Record<DbGetMergeModelResult>, IPoco
    {
        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("party_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long PartyId { get; set; }

        [Column("party_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string PartyCode { get; set; }

        [Column("price_type_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int PriceTypeId { get; set; }

        [Column("reference_number")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("item_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemName { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer", 0, false, "")]
        public int Quantity { get; set; }

        [Column("unit_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string UnitName { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Discount { get; set; }

        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal ShippingCharge { get; set; }

        [Column("tax_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string TaxCode { get; set; }

        [Column("tax")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Tax { get; set; }

        [Column("non_taxable")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool NonTaxable { get; set; }

        [Column("salesperson_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SalespersonId { get; set; }

        [Column("shipper_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ShipperId { get; set; }

        [Column("store_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int StoreId { get; set; }

        [Column("shipping_addresss_code")]
        [ColumnDbType("text", 0, false, "")]
        public string ShippingAddresssCode { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }
    }
}