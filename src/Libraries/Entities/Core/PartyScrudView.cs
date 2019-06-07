// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.party_scrud_view")]
    [ExplicitColumns]
    public sealed class PartyScrudView : PetaPocoDB.Record<PartyScrudView>, IPoco
    {
        [Column("party_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PartyId { get; set; }

        [Column("party_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PartyTypeId { get; set; }

        [Column("is_supplier")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsSupplier { get; set; }

        [Column("party_type")]
        [ColumnDbType("text", 0, true, "")]
        public string PartyType { get; set; }

        [Column("party_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string PartyCode { get; set; }

        [Column("first_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string MiddleName { get; set; }

        [Column("last_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string LastName { get; set; }

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CurrencyCode { get; set; }

        [Column("party_name")]
        [ColumnDbType("varchar", 0, true, "")]
        public string PartyName { get; set; }

        [Column("company_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string CompanyName { get; set; }

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

        [Column("state")]
        [ColumnDbType("text", 0, true, "")]
        public string State { get; set; }

        [Column("country")]
        [ColumnDbType("text", 0, true, "")]
        public string Country { get; set; }

        [Column("allow_credit")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")]
        [ColumnDbType("int2", 0, true, "")]
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? MaximumCreditAmount { get; set; }

        [Column("pan_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PanNumber { get; set; }

        [Column("sst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SstNumber { get; set; }

        [Column("cst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CstNumber { get; set; }

        [Column("phone")]
        [ColumnDbType("varchar", 24, true, "")]
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

        [Column("account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AccountId { get; set; }

        [Column("account_number")]
        [ColumnDbType("varchar", 12, true, "")]
        public string AccountNumber { get; set; }

        [Column("gl_head")]
        [ColumnDbType("text", 0, true, "")]
        public string GlHead { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }
    }
}