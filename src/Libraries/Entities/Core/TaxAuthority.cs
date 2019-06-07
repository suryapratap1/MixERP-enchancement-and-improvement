// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("tax_authority_id", autoIncrement = true)]
    [TableName("core.tax_authorities")]
    [ExplicitColumns]
    public sealed class TaxAuthority : PetaPocoDB.Record<TaxAuthority>, IPoco
    {
        [Column("tax_authority_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.tax_authorities_tax_authority_id_seq'::regclass)")]
        public int TaxAuthorityId { get; set; }

        [Column("tax_master_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int TaxMasterId { get; set; }

        [Column("tax_authority_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string TaxAuthorityCode { get; set; }

        [Column("tax_authority_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string TaxAuthorityName { get; set; }

        [Column("country_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CountryId { get; set; }

        [Column("state_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StateId { get; set; }

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

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}