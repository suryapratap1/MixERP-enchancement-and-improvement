// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.country_scrud_view")]
    [ExplicitColumns]
    public sealed class CountryScrudView : PetaPocoDB.Record<CountryScrudView>, IPoco
    {
        [Column("country_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountryId { get; set; }

        [Column("country_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CountryCode { get; set; }

        [Column("country_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string CountryName { get; set; }
    }
}