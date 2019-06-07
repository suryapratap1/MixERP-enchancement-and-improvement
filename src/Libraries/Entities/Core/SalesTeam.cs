// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("sales_team_id", autoIncrement = true)]
    [TableName("core.sales_teams")]
    [ExplicitColumns]
    public sealed class SalesTeam : PetaPocoDB.Record<SalesTeam>, IPoco
    {
        [Column("sales_team_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.sales_teams_sales_team_id_seq'::regclass)")]
        public int SalesTeamId { get; set; }

        [Column("sales_team_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string SalesTeamCode { get; set; }

        [Column("sales_team_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string SalesTeamName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}