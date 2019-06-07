// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.tax_authority_scrud_view")]
    [ExplicitColumns]
    public sealed class TaxAuthorityScrudView : PetaPocoDB.Record<TaxAuthorityScrudView>, IPoco
    {
        [Column("tax_authority_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TaxAuthorityId { get; set; }

        [Column("tax_master")]
        [ColumnDbType("text", 0, true, "")]
        public string TaxMaster { get; set; }

        [Column("tax_authority_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string TaxAuthorityCode { get; set; }

        [Column("tax_authority_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string TaxAuthorityName { get; set; }

        [Column("country")]
        [ColumnDbType("text", 0, true, "")]
        public string Country { get; set; }

        [Column("county")]
        [ColumnDbType("text", 0, true, "")]
        public string County { get; set; }

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
        [ColumnDbType("varchar", 50, true, "")]
        public string Street { get; set; }

        [Column("city")]
        [ColumnDbType("varchar", 50, true, "")]
        public string City { get; set; }

        [Column("phone")]
        [ColumnDbType("varchar", 100, true, "")]
        public string Phone { get; set; }

        [Column("fax")]
        [ColumnDbType("varchar", 24, true, "")]
        public string Fax { get; set; }

        [Column("cell")]
        [ColumnDbType("varchar", 24, true, "")]
        public string Cell { get; set; }

        [Column("email")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Email { get; set; }

        [Column("url")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Url { get; set; }
    }
}