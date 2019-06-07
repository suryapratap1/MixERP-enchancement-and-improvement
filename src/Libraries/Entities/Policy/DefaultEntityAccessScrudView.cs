// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("policy.default_entity_access_scrud_view")]
    [ExplicitColumns]
    public sealed class DefaultEntityAccessScrudView : PetaPocoDB.Record<DefaultEntityAccessScrudView>, IPoco
    {
        [Column("default_entity_access_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? DefaultEntityAccessId { get; set; }

        [Column("entity_name")]
        [ColumnDbType("varchar", 0, true, "")]
        public string EntityName { get; set; }

        [Column("role_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RoleName { get; set; }

        [Column("access_type_name")]
        [ColumnDbType("varchar", 0, true, "")]
        public string AccessTypeName { get; set; }

        [Column("allow_access")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? AllowAccess { get; set; }
    }
}