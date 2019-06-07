// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.sales_team_selector_view")]
    [ExplicitColumns]
    public sealed class SalesTeamSelectorView : PetaPocoDB.Record<SalesTeamSelectorView>, IPoco
    {
        [Column("sales_team_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTeamId { get; set; }

        [Column("sales_team_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string SalesTeamCode { get; set; }

        [Column("sales_team_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SalesTeamName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}