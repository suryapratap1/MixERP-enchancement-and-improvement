// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.shipping_address_scrud_view")]
    [ExplicitColumns]
    public sealed class ShippingAddressScrudView : PetaPocoDB.Record<ShippingAddressScrudView>, IPoco
    {
        [Column("shipping_address_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ShippingAddressId { get; set; }

        [Column("shipping_address_code")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ShippingAddressCode { get; set; }

        [Column("party")]
        [ColumnDbType("text", 0, true, "")]
        public string Party { get; set; }

        [Column("state")]
        [ColumnDbType("text", 0, true, "")]
        public string State { get; set; }

        [Column("country")]
        [ColumnDbType("text", 0, true, "")]
        public string Country { get; set; }

        [Column("zip_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ZipCode { get; set; }

        [Column("address_line_1")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AddressLine1 { get; set; }

        [Column("address_line_2")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AddressLine2 { get; set; }

        [Column("street")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Street { get; set; }

        [Column("city")]
        [ColumnDbType("varchar", 128, true, "")]
        public string City { get; set; }
    }
}