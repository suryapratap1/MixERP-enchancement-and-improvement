// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Config
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("config.scrud_factory_scrud_view")]
    [ExplicitColumns]
    public sealed class ScrudFactoryScrudView : PetaPocoDB.Record<ScrudFactoryScrudView>, IPoco
    {
        [Column("key")]
        [ColumnDbType("text", 0, true, "")]
        public string Key { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }
    }
}