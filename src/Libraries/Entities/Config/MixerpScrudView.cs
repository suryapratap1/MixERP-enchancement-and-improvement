// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Config
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("config.mixerp_scrud_view")]
    [ExplicitColumns]
    public sealed class MixerpScrudView : PetaPocoDB.Record<MixerpScrudView>, IPoco
    {
        [Column("key")]
        [ColumnDbType("text", 0, true, "")]
        public string Key { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, true, "")]
        public string Description { get; set; }
    }
}