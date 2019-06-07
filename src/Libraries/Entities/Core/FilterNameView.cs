// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.filter_name_view")]
    [ExplicitColumns]
    public sealed class FilterNameView : PetaPocoDB.Record<FilterNameView>, IPoco
    {
        [Column("object_name")]
        [ColumnDbType("text", 0, true, "")]
        public string ObjectName { get; set; }

        [Column("filter_name")]
        [ColumnDbType("text", 0, true, "")]
        public string FilterName { get; set; }

        [Column("is_default")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsDefault { get; set; }
    }
}