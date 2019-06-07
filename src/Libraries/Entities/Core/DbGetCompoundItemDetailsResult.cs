// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("core.get_compound_item_details")]
    [ExplicitColumns]
    public sealed class DbGetCompoundItemDetailsResult : PetaPocoDB.Record<DbGetCompoundItemDetailsResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")]
        public int Id { get; set; }

        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("text", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("text", 0, false, "")]
        public string ItemName { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int Quantity { get; set; }

        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UnitId { get; set; }

        [Column("unit_name")]
        [ColumnDbType("text", 0, false, "")]
        public string UnitName { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Price { get; set; }

        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Discount { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SalesTaxId { get; set; }

        [Column("sales_tax_code")]
        [ColumnDbType("text", 0, false, "")]
        public string SalesTaxCode { get; set; }

        [Column("computed_tax")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal ComputedTax { get; set; }
    }
}