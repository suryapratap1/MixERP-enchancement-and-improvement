// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("party_id", autoIncrement = true)]
    [TableName("core.parties")]
    [ExplicitColumns]
    public sealed class Party : PetaPocoDB.Record<Party>, IPoco
    {
        [Column("party_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.parties_party_id_seq'::regclass)")]
        public long PartyId { get; set; }

        [Column("party_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int PartyTypeId { get; set; }

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

        [Column("company_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string CompanyName { get; set; }

        [Column("date_of_birth")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? DateOfBirth { get; set; }

        [Column("entity_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EntityId { get; set; }

        [Column("industry_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? IndustryId { get; set; }

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

        [Column("pan_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PanNumber { get; set; }

        [Column("sst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SstNumber { get; set; }

        [Column("cst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CstNumber { get; set; }

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CurrencyCode { get; set; }

        [Column("allow_credit")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")]
        [ColumnDbType("int2", 0, true, "")]
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? MaximumCreditAmount { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AccountId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("party_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string PartyName { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }
    }
}