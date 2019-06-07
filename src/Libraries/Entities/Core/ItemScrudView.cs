// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.item_scrud_view")]
    [ExplicitColumns]
    public sealed class ItemScrudView : PetaPocoDB.Record<ItemScrudView>, IPoco
    {
        [Column("item_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string ItemName { get; set; }

        [Column("item_group")]
        [ColumnDbType("text", 0, true, "")]
        public string ItemGroup { get; set; }

        [Column("maintain_stock")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? MaintainStock { get; set; }

        [Column("brand")]
        [ColumnDbType("text", 0, true, "")]
        public string Brand { get; set; }

        [Column("preferred_supplier")]
        [ColumnDbType("text", 0, true, "")]
        public string PreferredSupplier { get; set; }

        [Column("lead_time_in_days")]
        [ColumnDbType("int4", 0, true, "")]
        public int? LeadTimeInDays { get; set; }

        [Column("weight_in_grams")]
        [ColumnDbType("float8", 0, true, "")]
        public double? WeightInGrams { get; set; }

        [Column("width_in_centimeters")]
        [ColumnDbType("float8", 0, true, "")]
        public double? WidthInCentimeters { get; set; }

        [Column("height_in_centimeters")]
        [ColumnDbType("float8", 0, true, "")]
        public double? HeightInCentimeters { get; set; }

        [Column("length_in_centimeters")]
        [ColumnDbType("float8", 0, true, "")]
        public double? LengthInCentimeters { get; set; }

        [Column("machinable")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? Machinable { get; set; }

        [Column("preferred_shipping_mail_type")]
        [ColumnDbType("text", 0, true, "")]
        public string PreferredShippingMailType { get; set; }

        [Column("preferred_shipping_package_shape")]
        [ColumnDbType("text", 0, true, "")]
        public string PreferredShippingPackageShape { get; set; }

        [Column("unit")]
        [ColumnDbType("text", 0, true, "")]
        public string Unit { get; set; }

        [Column("hot_item")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? HotItem { get; set; }

        [Column("cost_price")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? CostPrice { get; set; }

        [Column("selling_price")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? SellingPrice { get; set; }

        [Column("selling_price_includes_tax")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? SellingPriceIncludesTax { get; set; }

        [Column("sales_tax")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTax { get; set; }

        [Column("reorder_unit")]
        [ColumnDbType("text", 0, true, "")]
        public string ReorderUnit { get; set; }

        [Column("reorder_level")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ReorderLevel { get; set; }

        [Column("reorder_quantity")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ReorderQuantity { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }
    }
}