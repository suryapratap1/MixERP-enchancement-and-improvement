// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Localization
{
    [PrimaryKey("resource_id", autoIncrement = true)]
    [TableName("localization.resources")]
    [ExplicitColumns]
    public sealed class Resource : PetaPocoDB.Record<Resource>, IPoco
    {
        [Column("resource_id")]
        [ColumnDbType("int4", 0, false, "nextval('localization.resources_resource_id_seq'::regclass)")]
        public int ResourceId { get; set; }

        [Column("resource_class")]
        [ColumnDbType("text", 0, true, "")]
        public string ResourceClass { get; set; }

        [Column("key")]
        [ColumnDbType("text", 0, true, "")]
        public string Key { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }
    }
}