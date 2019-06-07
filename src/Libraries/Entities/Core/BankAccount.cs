// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("account_id", autoIncrement = false)]
    [TableName("core.bank_accounts")]
    [ExplicitColumns]
    public sealed class BankAccount : PetaPocoDB.Record<BankAccount>, IPoco
    {
        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long AccountId { get; set; }

        [Column("maintained_by_user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int MaintainedByUserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("bank_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string BankName { get; set; }

        [Column("bank_branch")]
        [ColumnDbType("varchar", 128, false, "")]
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

        [Column("relationship_officer_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string RelationshipOfficerName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("is_merchant_account")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsMerchantAccount { get; set; }
    }
}