// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_reorder_view_function")]
    [ExplicitColumns]
    public sealed class DbGetReorderViewFunctionResult : PetaPocoDB.Record<DbGetReorderViewFunctionResult>, IPoco
    {
        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemName { get; set; }

        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UnitId { get; set; }

        [Column("unit")]
        [ColumnDbType("text", 0, false, "")]
        public string Unit { get; set; }

        [Column("quantity_on_hand")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal QuantityOnHand { get; set; }

        [Column("reorder_level")]
        [ColumnDbType("integer", 0, false, "")]
        public int ReorderLevel { get; set; }

        [Column("reorder_quantity")]
        [ColumnDbType("integer", 0, false, "")]
        public int ReorderQuantity { get; set; }

        [Column("preferred_supplier_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long PreferredSupplierId { get; set; }

        [Column("preferred_supplier")]
        [ColumnDbType("text", 0, false, "")]
        public string PreferredSupplier { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Price { get; set; }
    }
}