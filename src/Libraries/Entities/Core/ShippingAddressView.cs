// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.shipping_address_view")]
    [ExplicitColumns]
    public sealed class ShippingAddressView : PetaPocoDB.Record<ShippingAddressView>, IPoco
    {
        [Column("shipping_address_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ShippingAddressId { get; set; }

        [Column("shipping_address_code")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ShippingAddressCode { get; set; }

        [Column("zip_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ZipCode { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PartyId { get; set; }

        [Column("country_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountryId { get; set; }

        [Column("state_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StateId { get; set; }

        [Column("country_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string CountryName { get; set; }

        [Column("state_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string StateName { get; set; }

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