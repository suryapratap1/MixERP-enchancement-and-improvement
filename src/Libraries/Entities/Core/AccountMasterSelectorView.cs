// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.account_master_selector_view")]
    [ExplicitColumns]
    public sealed class AccountMasterSelectorView : PetaPocoDB.Record<AccountMasterSelectorView>, IPoco
    {
        [Column("account_master_id")]
        [ColumnDbType("int2", 0, true, "")]
        public short? AccountMasterId { get; set; }

        [Column("account_master_code")]
        [ColumnDbType("varchar", 3, true, "")]
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")]
        [ColumnDbType("varchar", 40, true, "")]
        public string AccountMasterName { get; set; }

        [Column("normally_debit")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? NormallyDebit { get; set; }

        [Column("parent_account_master_id")]
        [ColumnDbType("int2", 0, true, "")]
        public short? ParentAccountMasterId { get; set; }
    }
}