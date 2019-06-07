// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Localization
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("localization.localized_resource_view")]
    [ExplicitColumns]
    public sealed class LocalizedResourceView : PetaPocoDB.Record<LocalizedResourceView>, IPoco
    {
        [Column("key")]
        [ColumnDbType("text", 0, true, "")]
        public string Key { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }
    }
}