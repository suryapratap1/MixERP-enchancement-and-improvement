// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("rounding_method_code", autoIncrement = false)]
    [TableName("core.rounding_methods")]
    [ExplicitColumns]
    public sealed class RoundingMethod : PetaPocoDB.Record<RoundingMethod>, IPoco
    {
        [Column("rounding_method_code")]
        [ColumnDbType("varchar", 4, false, "")]
        public string RoundingMethodCode { get; set; }

        [Column("rounding_method_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string RoundingMethodName { get; set; }
    }
}