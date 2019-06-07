// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("account_id", autoIncrement = true)]
    [TableName("core.accounts")]
    [ExplicitColumns]
    public sealed class Account : PetaPocoDB.Record<Account>, IPoco
    {
        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.accounts_account_id_seq'::regclass)")]
        public long AccountId { get; set; }

        [Column("account_master_id")]
        [ColumnDbType("int2", 0, false, "")]
        public short AccountMasterId { get; set; }

        [Column("account_number")]
        [ColumnDbType("varchar", 12, false, "")]
        public string AccountNumber { get; set; }

        [Column("external_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ExternalCode { get; set; }

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CurrencyCode { get; set; }

        [Column("account_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string AccountName { get; set; }

        [Column("description")]
        [ColumnDbType("varchar", 200, true, "")]
        public string Description { get; set; }

        [Column("confidential")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Confidential { get; set; }

        [Column("is_transaction_node")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool IsTransactionNode { get; set; }

        [Column("sys_type")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool SysType { get; set; }

        [Column("parent_account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ParentAccountId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}