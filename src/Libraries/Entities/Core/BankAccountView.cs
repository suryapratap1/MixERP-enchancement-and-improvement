// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.bank_account_view")]
    [ExplicitColumns]
    public sealed class BankAccountView : PetaPocoDB.Record<BankAccountView>, IPoco
    {
        [Column("account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AccountId { get; set; }

        [Column("account_number")]
        [ColumnDbType("varchar", 12, true, "")]
        public string AccountNumber { get; set; }

        [Column("account_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string AccountName { get; set; }

        [Column("maintained_by")]
        [ColumnDbType("varchar", 50, true, "")]
        public string MaintainedBy { get; set; }

        [Column("bank_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankName { get; set; }

        [Column("bank_branch")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankBranch { get; set; }

        [Column("bank_contact_number")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankContactNumber { get; set; }

        [Column("bank_address")]
        [ColumnDbType("text", 0, true, "")]
        public string BankAddress { get; set; }

        [Column("bank_account_number")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankAccountNumber { get; set; }

        [Column("bank_account_type")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankAccountType { get; set; }

        [Column("relation_officer")]
        [ColumnDbType("varchar", 128, true, "")]
        public string RelationOfficer { get; set; }
    }
}