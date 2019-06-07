// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.entity_scrud_view")]
    [ExplicitColumns]
    public sealed class EntityScrudView : PetaPocoDB.Record<EntityScrudView>, IPoco
    {
        [Column("entity_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EntityId { get; set; }

        [Column("entity_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string EntityName { get; set; }
    }
}