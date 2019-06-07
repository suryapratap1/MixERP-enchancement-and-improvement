using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.purchase_reorder_type")]
    [ExplicitColumns]
    public sealed class PurchaseReorderType : PetaPocoDB.Record<PurchaseReorderType>, IPoco
    {
        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("supplier_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string SupplierCode { get; set; }

        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UnitId { get; set; }

        [Column("price")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("tax_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string TaxCode { get; set; }

        [Column("order_quantity")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int OrderQuantity { get; set; }
    }
}