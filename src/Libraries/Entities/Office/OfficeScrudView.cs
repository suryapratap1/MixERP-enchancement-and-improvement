// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.office_scrud_view")]
    [ExplicitColumns]
    public sealed class OfficeScrudView : PetaPocoDB.Record<OfficeScrudView>, IPoco
    {
        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("office_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string OfficeCode { get; set; }

        [Column("office_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string OfficeName { get; set; }

        [Column("nick_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string NickName { get; set; }

        [Column("registration_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? RegistrationDate { get; set; }

        [Column("currency")]
        [ColumnDbType("text", 0, true, "")]
        public string Currency { get; set; }

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

        [Column("zip_code")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ZipCode { get; set; }

        [Column("country")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Country { get; set; }

        [Column("phone")]
        [ColumnDbType("varchar", 24, true, "")]
        public string Phone { get; set; }

        [Column("fax")]
        [ColumnDbType("varchar", 24, true, "")]
        public string Fax { get; set; }

        [Column("email")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Email { get; set; }

        [Column("url")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Url { get; set; }

        [Column("registration_number")]
        [ColumnDbType("varchar", 24, true, "")]
        public string RegistrationNumber { get; set; }

        [Column("parent_office")]
        [ColumnDbType("text", 0, true, "")]
        public string ParentOffice { get; set; }
    }
}