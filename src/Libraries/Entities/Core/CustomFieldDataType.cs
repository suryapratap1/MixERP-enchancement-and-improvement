// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("data_type", autoIncrement = false)]
    [TableName("core.custom_field_data_types")]
    [ExplicitColumns]
    public sealed class CustomFieldDataType : PetaPocoDB.Record<CustomFieldDataType>, IPoco
    {
        [Column("data_type")]
        [ColumnDbType("varchar", 50, false, "")]
        public string DataType { get; set; }

        [Column("is_number")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? IsNumber { get; set; }

        [Column("is_date")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? IsDate { get; set; }

        [Column("is_boolean")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? IsBoolean { get; set; }

        [Column("is_long_text")]
        [ColumnDbType("bool", 0, true, "false")]
        public bool? IsLongText { get; set; }
    }
}