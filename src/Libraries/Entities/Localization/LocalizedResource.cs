// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Localization
{
    [PrimaryKey("localized_resource_id", autoIncrement = true)]
    [TableName("localization.localized_resources")]
    [ExplicitColumns]
    public sealed class LocalizedResource : PetaPocoDB.Record<LocalizedResource>, IPoco
    {
        [Column("resource_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ResourceId { get; set; }

        [Column("culture_code")]
        [ColumnDbType("text", 0, false, "")]
        public string CultureCode { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, false, "")]
        public string Value { get; set; }

        [Column("localized_resource_id")]
        [ColumnDbType("int8", 0, false, "nextval('localization.localized_resources_localized_resource_id_seq'::regclass)")]
        public long LocalizedResourceId { get; set; }
    }
}