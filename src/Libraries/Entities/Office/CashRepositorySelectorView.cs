// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.cash_repository_selector_view")]
    [ExplicitColumns]
    public sealed class CashRepositorySelectorView : PetaPocoDB.Record<CashRepositorySelectorView>, IPoco
    {
        [Column("cash_repository_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashRepositoryId { get; set; }

        [Column("cash_repository_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CashRepositoryCode { get; set; }

        [Column("cash_repository_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CashRepositoryName { get; set; }

        [Column("parent_cr_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ParentCrCode { get; set; }

        [Column("parent_cr_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ParentCrName { get; set; }

        [Column("description")]
        [ColumnDbType("varchar", 100, true, "")]
        public string Description { get; set; }
    }
}