// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.state_scrud_view")]
    [ExplicitColumns]
    public sealed class StateScrudView : PetaPocoDB.Record<StateScrudView>, IPoco
    {
        [Column("state_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StateId { get; set; }

        [Column("country_name")]
        [ColumnDbType("text", 0, true, "")]
        public string CountryName { get; set; }

        [Column("state_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string StateCode { get; set; }

        [Column("state_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string StateName { get; set; }
    }
}