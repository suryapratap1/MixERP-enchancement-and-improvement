// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.county_scrud_view")]
    [ExplicitColumns]
    public sealed class CountyScrudView : PetaPocoDB.Record<CountyScrudView>, IPoco
    {
        [Column("county_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountyId { get; set; }

        [Column("county_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CountyCode { get; set; }

        [Column("county_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string CountyName { get; set; }

        [Column("state")]
        [ColumnDbType("text", 0, true, "")]
        public string State { get; set; }
    }
}