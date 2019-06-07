// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.industry_scrud_view")]
    [ExplicitColumns]
    public sealed class IndustryScrudView : PetaPocoDB.Record<IndustryScrudView>, IPoco
    {
        [Column("industry_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? IndustryId { get; set; }

        [Column("industry_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string IndustryName { get; set; }

        [Column("parent_industry_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string ParentIndustryName { get; set; }
    }
}