using System;

namespace MixERP.Net.EntityParser
{
    public class EntityColumn
    {
        public string ColumnName { get; set; }
        public string PropertyName { get; set; }
        public string DataType { get; set; }
        public string DbDataType { get; set; }
        public bool IsNullable { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsSerial { get; set; }
        public string Value { get; set; }
        public int MaxLength { get; set; }
    }
}