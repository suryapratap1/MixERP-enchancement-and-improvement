// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.party_user_control_view")]
    [ExplicitColumns]
    public sealed class PartyUserControlView : PetaPocoDB.Record<PartyUserControlView>, IPoco
    {
        [Column("party_type_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string PartyTypeCode { get; set; }

        [Column("party_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PartyTypeName { get; set; }

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

        [Column("allow_credit")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AllowCredit { get; set; }

        [Column("maximum_credit_period")]
        [ColumnDbType("int2", 0, true, "")]
        public short? MaximumCreditPeriod { get; set; }

        [Column("maximum_credit_amount")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? MaximumCreditAmount { get; set; }

        [Column("account_number")]
        [ColumnDbType("varchar", 12, true, "")]
        public string AccountNumber { get; set; }

        [Column("account_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string AccountName { get; set; }

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

        [Column("state")]
        [ColumnDbType("text", 0, true, "")]
        public string State { get; set; }

        [Column("country")]
        [ColumnDbType("text", 0, true, "")]
        public string Country { get; set; }
    }
}