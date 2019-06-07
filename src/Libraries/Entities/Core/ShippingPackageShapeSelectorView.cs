// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.shipping_package_shape_selector_view")]
    [ExplicitColumns]
    public sealed class ShippingPackageShapeSelectorView : PetaPocoDB.Record<ShippingPackageShapeSelectorView>, IPoco
    {
        [Column("shipping_package_shape_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ShippingPackageShapeId { get; set; }

        [Column("shipping_package_shape_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ShippingPackageShapeCode { get; set; }

        [Column("shipping_package_shape_name")]
        [ColumnDbType("varchar", 64, true, "")]
        public string ShippingPackageShapeName { get; set; }

        [Column("is_rectangular")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsRectangular { get; set; }
    }
}