// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Public
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("public.get_entities")]
    [ExplicitColumns]
    public sealed class DbGetEntitiesResult : PetaPocoDB.Record<DbGetEntitiesResult>, IPoco
    {
        [Column("table_schema")]
        [ColumnDbType("name", 0, false, "")]
        public string TableSchema { get; set; }

        [Column("table_name")]
        [ColumnDbType("name", 0, false, "")]
        public string TableName { get; set; }

        [Column("table_type")]
        [ColumnDbType("text", 0, false, "")]
        public string TableType { get; set; }

        [Column("has_duplicate")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool HasDuplicate { get; set; }
    }
}