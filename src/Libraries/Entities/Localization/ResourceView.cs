// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Localization
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("localization.resource_view")]
    [ExplicitColumns]
    public sealed class ResourceView : PetaPocoDB.Record<ResourceView>, IPoco
    {
        [Column("resource_class")]
        [ColumnDbType("text", 0, true, "")]
        public string ResourceClass { get; set; }

        [Column("culture")]
        [ColumnDbType("text", 0, true, "")]
        public string Culture { get; set; }

        [Column("key")]
        [ColumnDbType("text", 0, true, "")]
        public string Key { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }
    }
}