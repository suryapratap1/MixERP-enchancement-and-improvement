// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.sales_team_scrud_view")]
    [ExplicitColumns]
    public sealed class SalesTeamScrudView : PetaPocoDB.Record<SalesTeamScrudView>, IPoco
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
    }
}