// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.brand_scrud_view")]
    [ExplicitColumns]
    public sealed class BrandScrudView : PetaPocoDB.Record<BrandScrudView>, IPoco
    {
        [Column("brand_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? BrandId { get; set; }

        [Column("brand_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string BrandCode { get; set; }

        [Column("brand_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string BrandName { get; set; }
    }
}