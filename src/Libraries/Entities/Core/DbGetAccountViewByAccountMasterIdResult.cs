// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("core.get_account_view_by_account_master_id")]
    [ExplicitColumns]
    public sealed class DbGetAccountViewByAccountMasterIdResult : PetaPocoDB.Record<DbGetAccountViewByAccountMasterIdResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long Id { get; set; }

        [Column("account_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long AccountId { get; set; }

        [Column("account_name")]
        [ColumnDbType("text", 0, false, "")]
        public string AccountName { get; set; }
    }
}