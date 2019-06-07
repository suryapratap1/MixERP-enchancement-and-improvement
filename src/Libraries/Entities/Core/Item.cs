// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("item_id", autoIncrement = true)]
    [TableName("core.items")]
    [ExplicitColumns]
    public sealed class Item : PetaPocoDB.Record<Item>, IPoco
    {
        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.items_item_id_seq'::regclass)")]
        public int ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("varchar", 150, false, "")]
        public string ItemName { get; set; }

        [Column("item_group_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ItemGroupId { get; set; }

        [Column("item_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ItemTypeId { get; set; }

        [Column("brand_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int BrandId { get; set; }

        [Column("preferred_supplier_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long PreferredSupplierId { get; set; }

        [Column("lead_time_in_days")]
        [ColumnDbType("int4", 0, false, "0")]
        public int LeadTimeInDays { get; set; }

        [Column("weight_in_grams")]
        [ColumnDbType("float8", 0, false, "0")]
        public double WeightInGrams { get; set; }

        [Column("width_in_centimeters")]
        [ColumnDbType("float8", 0, false, "0")]
        public double WidthInCentimeters { get; set; }

        [Column("height_in_centimeters")]
        [ColumnDbType("float8", 0, false, "0")]
        public double HeightInCentimeters { get; set; }

        [Column("length_in_centimeters")]
        [ColumnDbType("float8", 0, false, "0")]
        public double LengthInCentimeters { get; set; }

        [Column("machinable")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Machinable { get; set; }

        [Column("preferred_shipping_mail_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PreferredShippingMailTypeId { get; set; }

        [Column("shipping_package_shape_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ShippingPackageShapeId { get; set; }

        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UnitId { get; set; }

        [Column("hot_item")]
        [ColumnDbType("bool", 0, false, "")]
        public bool HotItem { get; set; }

        [Column("cost_price")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal CostPrice { get; set; }

        [Column("selling_price")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal SellingPrice { get; set; }

        [Column("selling_price_includes_tax")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool SellingPriceIncludesTax { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTaxId { get; set; }

        [Column("reorder_unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ReorderUnitId { get; set; }

        [Column("reorder_level")]
        [ColumnDbType("int4", 0, false, "")]
        public int ReorderLevel { get; set; }

        [Column("reorder_quantity")]
        [ColumnDbType("int4", 0, false, "0")]
        public int ReorderQuantity { get; set; }

        [Column("maintain_stock")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool MaintainStock { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }

        [Column("is_variant_of")]
        [ColumnDbType("int4", 0, true, "")]
        public int? IsVariantOf { get; set; }

        [Column("allow_sales")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool AllowSales { get; set; }

        [Column("allow_purchase")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool AllowPurchase { get; set; }
    }
}