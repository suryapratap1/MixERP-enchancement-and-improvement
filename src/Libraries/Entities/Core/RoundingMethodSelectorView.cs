// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.rounding_method_selector_view")]
    [ExplicitColumns]
    public sealed class RoundingMethodSelectorView : PetaPocoDB.Record<RoundingMethodSelectorView>, IPoco
    {
        [Column("rounding_method_code")]
        [ColumnDbType("varchar", 4, true, "")]
        public string RoundingMethodCode { get; set; }

        [Column("rounding_method_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RoundingMethodName { get; set; }
    }
}