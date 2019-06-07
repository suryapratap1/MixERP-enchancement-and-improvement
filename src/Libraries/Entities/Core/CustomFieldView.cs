// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.custom_field_view")]
    [ExplicitColumns]
    public sealed class CustomFieldView : PetaPocoDB.Record<CustomFieldView>, IPoco
    {
        [Column("table_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string TableName { get; set; }

        [Column("key_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string KeyName { get; set; }

        [Column("custom_field_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CustomFieldSetupId { get; set; }

        [Column("form_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string FormName { get; set; }

        [Column("field_order")]
        [ColumnDbType("int4", 0, true, "")]
        public int? FieldOrder { get; set; }

        [Column("field_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string FieldName { get; set; }

        [Column("field_label")]
        [ColumnDbType("varchar", 100, true, "")]
        public string FieldLabel { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, true, "")]
        public string Description { get; set; }

        [Column("data_type")]
        [ColumnDbType("varchar", 50, true, "")]
        public string DataType { get; set; }

        [Column("is_number")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsNumber { get; set; }

        [Column("is_date")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsDate { get; set; }

        [Column("is_boolean")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsBoolean { get; set; }

        [Column("is_long_text")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsLongText { get; set; }

        [Column("resource_id")]
        [ColumnDbType("text", 0, true, "")]
        public string ResourceId { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }
    }
}