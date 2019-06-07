// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("custom_field_setup_id", autoIncrement = true)]
    [TableName("core.custom_field_setup")]
    [ExplicitColumns]
    public sealed class CustomFieldSetup : PetaPocoDB.Record<CustomFieldSetup>, IPoco
    {
        [Column("custom_field_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.custom_field_setup_custom_field_setup_id_seq'::regclass)")]
        public int CustomFieldSetupId { get; set; }

        [Column("form_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string FormName { get; set; }

        [Column("field_order")]
        [ColumnDbType("int4", 0, false, "0")]
        public int FieldOrder { get; set; }

        [Column("field_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string FieldName { get; set; }

        [Column("field_label")]
        [ColumnDbType("varchar", 100, false, "")]
        public string FieldLabel { get; set; }

        [Column("data_type")]
        [ColumnDbType("varchar", 50, true, "")]
        public string DataType { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, false, "")]
        public string Description { get; set; }
    }
}