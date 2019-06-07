// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("account_master_id", autoIncrement = false)]
    [TableName("core.account_masters")]
    [ExplicitColumns]
    public sealed class AccountMaster : PetaPocoDB.Record<AccountMaster>, IPoco
    {
        [Column("account_master_id")]
        [ColumnDbType("int2", 0, false, "")]
        public short AccountMasterId { get; set; }

        [Column("account_master_code")]
        [ColumnDbType("varchar", 3, false, "")]
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")]
        [ColumnDbType("varchar", 40, false, "")]
        public string AccountMasterName { get; set; }

        [Column("normally_debit")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool NormallyDebit { get; set; }

        [Column("parent_account_master_id")]
        [ColumnDbType("int2", 0, true, "")]
        public short? ParentAccountMasterId { get; set; }
    }
}