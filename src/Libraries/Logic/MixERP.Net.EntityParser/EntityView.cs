using System.Collections.Generic;

namespace MixERP.Net.EntityParser
{
    public class EntityView
    {
        public string PrimaryKey { get; set; }
        public List<EntityColumn> Columns { get; set; }
        public object PrimaryKeyValue { get; set; }
    }
}