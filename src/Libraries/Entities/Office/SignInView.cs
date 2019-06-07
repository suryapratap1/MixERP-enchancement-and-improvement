// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.sign_in_view")]
    [ExplicitColumns]
    public sealed class SignInView : PetaPocoDB.Record<SignInView>, IPoco
    {
        [Column("login_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? LoginId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("role_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RoleId { get; set; }

        [Column("role")]
        [ColumnDbType("text", 0, true, "")]
        public string Role { get; set; }

        [Column("role_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string RoleCode { get; set; }

        [Column("role_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RoleName { get; set; }

        [Column("is_admin")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsAdmin { get; set; }

        [Column("is_system")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsSystem { get; set; }

        [Column("browser")]
        [ColumnDbType("varchar", 500, true, "")]
        public string Browser { get; set; }

        [Column("ip_address")]
        [ColumnDbType("varchar", 50, true, "")]
        public string IpAddress { get; set; }

        [Column("login_date_time")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? LoginDateTime { get; set; }

        [Column("remote_user")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RemoteUser { get; set; }

        [Column("culture")]
        [ColumnDbType("varchar", 12, true, "")]
        public string Culture { get; set; }

        [Column("user_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string UserName { get; set; }

        [Column("full_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string FullName { get; set; }

        [Column("elevated")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? Elevated { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, true, "")]
        public string Office { get; set; }

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

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CurrencyCode { get; set; }

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

        [Column("pan_number")]
        [ColumnDbType("varchar", 24, true, "")]
        public string PanNumber { get; set; }

        [Column("allow_transaction_posting")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AllowTransactionPosting { get; set; }

        [Column("week_start_day")]
        [ColumnDbType("int4", 0, true, "")]
        public int? WeekStartDay { get; set; }

        [Column("logo_file")]
        [ColumnDbType("image", 0, true, "")]
        public string LogoFile { get; set; }

        [Column("sales_quotation_valid_duration")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesQuotationValidDuration { get; set; }
    }
}