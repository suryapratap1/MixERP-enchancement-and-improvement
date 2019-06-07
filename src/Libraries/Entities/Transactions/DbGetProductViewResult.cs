// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_product_view")]
    [ExplicitColumns]
    public sealed class DbGetProductViewResult : PetaPocoDB.Record<DbGetProductViewResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long Id { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("office")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Office { get; set; }

        [Column("party")]
        [ColumnDbType("text", 0, false, "")]
        public string Party { get; set; }

        [Column("price_type")]
        [ColumnDbType("text", 0, false, "")]
        public string PriceType { get; set; }

        [Column("amount")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Amount { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime TransactionTs { get; set; }

        [Column("user")]
        [ColumnDbType("character varying", 0, false, "")]
        public string User { get; set; }

        [Column("reference_number")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }

        [Column("book")]
        [ColumnDbType("text", 0, false, "")]
        public string Book { get; set; }

        [Column("salesperson")]
        [ColumnDbType("text", 0, false, "")]
        public string Salesperson { get; set; }

        [Column("is_credit")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool IsCredit { get; set; }

        [Column("shipper")]
        [ColumnDbType("text", 0, false, "")]
        public string Shipper { get; set; }

        [Column("shipping_address_code")]
        [ColumnDbType("text", 0, false, "")]
        public string ShippingAddressCode { get; set; }

        [Column("store")]
        [ColumnDbType("text", 0, false, "")]
        public string Store { get; set; }
    }
}