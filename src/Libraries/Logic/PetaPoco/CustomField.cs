namespace PetaPoco
{
    public sealed class CustomField
    {
        [Column("table_name")]
        public string TableName { get; set; }

        [Column("key_name")]
        public string KeyName { get; set; }

        [Column("custom_field_setup_id")]
        public int CustomFieldSetupId { get; set; }

        [Column("form_name")]
        public string FormName { get; set; }

        [Column("field_order")]
        public int? FieldOrder { get; set; }

        [Column("field_name")]
        public string FieldName { get; set; }

        [Column("field_label")]
        public string FieldLabel { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("data_type")]
        public string DataType { get; set; }

        [Column("is_number")]
        public bool? IsNumber { get; set; }

        [Column("is_date")]
        public bool? IsDate { get; set; }

        [Column("is_boolean")]
        public bool? IsBoolean { get; set; }

        [Column("is_long_text")]
        public bool? IsLongText { get; set; }

        [Column("resource_id")]
        public string ResourceId { get; set; }

        [Column("value")]
        public string Value { get; set; }

    }
}