// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.shipper_scrud_view")]
    [ExplicitColumns]
    public sealed class ShipperScrudView : PetaPocoDB.Record<ShipperScrudView>, IPoco
    {
        [Column("shipper_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ShipperId { get; set; }

        [Column("shipper_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ShipperCode { get; set; }

        [Column("company_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string CompanyName { get; set; }

        [Column("shipper_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string ShipperName { get; set; }

        [Column("po_box")]
        [ColumnDbType("varchar", 128, true, "")]
        public string PoBox { get; set; }

        [Column("address_line_1")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AddressLine1 { get; set; }

        [Column("address_line_2")]
        [ColumnDbType("varchar", 128, true, "")]
        public string AddressLine2 { get; set; }

        [Column("street")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Street { get; set; }

        [Column("city")]
        [ColumnDbType("varchar", 50, true, "")]
        public string City { get; set; }

        [Column("state")]
        [ColumnDbType("varchar", 50, true, "")]
        public string State { get; set; }

        [Column("country")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Country { get; set; }

        [Column("phone")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Phone { get; set; }

        [Column("fax")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Fax { get; set; }

        [Column("cell")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Cell { get; set; }

        [Column("email")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Email { get; set; }

        [Column("url")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Url { get; set; }

        [Column("contact_person")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactPerson { get; set; }

        [Column("contact_po_box")]
        [ColumnDbType("varchar", 128, true, "")]
        public string ContactPoBox { get; set; }

        [Column("contact_address_line_1")]
        [ColumnDbType("varchar", 128, true, "")]
        public string ContactAddressLine1 { get; set; }

        [Column("contact_address_line_2")]
        [ColumnDbType("varchar", 128, true, "")]
        public string ContactAddressLine2 { get; set; }

        [Column("contact_street")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactStreet { get; set; }

        [Column("contact_city")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactCity { get; set; }

        [Column("contact_state")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactState { get; set; }

        [Column("contact_country")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactCountry { get; set; }

        [Column("contact_email")]
        [ColumnDbType("varchar", 128, true, "")]
        public string ContactEmail { get; set; }

        [Column("contact_phone")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactPhone { get; set; }

        [Column("contact_cell")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactCell { get; set; }

        [Column("factory_address")]
        [ColumnDbType("varchar", 250, true, "")]
        public string FactoryAddress { get; set; }

        [Column("pan_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PanNumber { get; set; }

        [Column("sst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SstNumber { get; set; }

        [Column("cst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CstNumber { get; set; }

        [Column("account")]
        [ColumnDbType("text", 0, true, "")]
        public string Account { get; set; }
    }
}