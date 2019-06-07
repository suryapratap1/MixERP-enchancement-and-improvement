// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("shipping_address_id", autoIncrement = true)]
    [TableName("core.shipping_addresses")]
    [ExplicitColumns]
    public sealed class ShippingAddress : PetaPocoDB.Record<ShippingAddress>, IPoco
    {
        [Column("shipping_address_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.shipping_addresses_shipping_address_id_seq'::regclass)")]
        public long ShippingAddressId { get; set; }

        [Column("shipping_address_code")]
        [ColumnDbType("varchar", 24, false, "")]
        public string ShippingAddressCode { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long PartyId { get; set; }

        [Column("country_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CountryId { get; set; }

        [Column("state_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int StateId { get; set; }

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
        [ColumnDbType("varchar", 128, false, "")]
        public string City { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}