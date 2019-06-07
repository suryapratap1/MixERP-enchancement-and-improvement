// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("form_name", autoIncrement = false)]
    [TableName("core.custom_field_forms")]
    [ExplicitColumns]
    public sealed class CustomFieldForm : PetaPocoDB.Record<CustomFieldForm>, IPoco
    {
        [Column("form_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string FormName { get; set; }

        [Column("table_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string TableName { get; set; }

        [Column("key_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string KeyName { get; set; }
    }
}