// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.cash_account_selector_view")]
    [ExplicitColumns]
    public sealed class CashAccountSelectorView : PetaPocoDB.Record<CashAccountSelectorView>, IPoco
    {
        [Column("account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AccountId { get; set; }

        [Column("account_master")]
        [ColumnDbType("text", 0, true, "")]
        public string AccountMaster { get; set; }

        [Column("account_number")]
        [ColumnDbType("varchar", 12, true, "")]
        public string AccountNumber { get; set; }

        [Column("external_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ExternalCode { get; set; }

        [Column("currency")]
        [ColumnDbType("text", 0, true, "")]
        public string Currency { get; set; }

        [Column("account_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string AccountName { get; set; }

        [Column("description")]
        [ColumnDbType("varchar", 200, true, "")]
        public string Description { get; set; }

        [Column("confidential")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? Confidential { get; set; }

        [Column("is_transaction_node")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsTransactionNode { get; set; }

        [Column("sys_type")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? SysType { get; set; }

        [Column("account_master_id")]
        [ColumnDbType("int2", 0, true, "")]
        public short? AccountMasterId { get; set; }

        [Column("parent")]
        [ColumnDbType("text", 0, true, "")]
        public string Parent { get; set; }
    }
}