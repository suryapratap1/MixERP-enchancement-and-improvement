// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Config
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("config.switch_scrud_view")]
    [ExplicitColumns]
    public sealed class SwitchScrudView : PetaPocoDB.Record<SwitchScrudView>, IPoco
    {
        [Column("key")]
        [ColumnDbType("text", 0, true, "")]
        public string Key { get; set; }

        [Column("value")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? Value { get; set; }
    }
}