// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("config_id", autoIncrement = false)]
    [TableName("core.config")]
    [ExplicitColumns]
    public sealed class Config : PetaPocoDB.Record<Config>, IPoco
    {
        [Column("config_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ConfigId { get; set; }

        [Column("config_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string ConfigName { get; set; }
    }
}