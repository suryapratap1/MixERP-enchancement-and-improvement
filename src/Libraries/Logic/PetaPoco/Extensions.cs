using System;
using System.Text;

namespace PetaPoco
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnDbType : Attribute
    {
        public ColumnDbType()
        {
        }

        public ColumnDbType(string name)
        {
            this.Name = name;
        }

        public ColumnDbType(string name, int maxLength)
        {
            this.Name = name;
            this.MaxLength = maxLength;
        }

        public ColumnDbType(string name, int maxLength, bool isNullable, string defaultValue)
        {
            this.Name = name;
            this.MaxLength = maxLength;
            this.IsNullable = isNullable;
            this.DefaultValue = defaultValue;
        }

        public string Name { get; set; }
        public int MaxLength { get; set; }
        public string DefaultValue { get; set; }
        public bool IsNullable { get; set; }
    }
}