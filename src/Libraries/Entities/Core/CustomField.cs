// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("custom_field_id", autoIncrement = true)]
    [TableName("core.custom_fields")]
    [ExplicitColumns]
    public sealed class CustomField : PetaPocoDB.Record<CustomField>, IPoco
    {
        [Column("custom_field_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.custom_fields_custom_field_id_seq'::regclass)")]
        public long CustomFieldId { get; set; }

        [Column("custom_field_setup_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CustomFieldSetupId { get; set; }

        [Column("resource_id")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceId { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }
    }
}