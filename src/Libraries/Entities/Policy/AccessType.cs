// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("access_type_id", autoIncrement = false)]
    [TableName("policy.access_types")]
    [ExplicitColumns]
    public sealed class AccessType : PetaPocoDB.Record<AccessType>, IPoco
    {
        [Column("access_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int AccessTypeId { get; set; }

        [Column("access_type_name")]
        [ColumnDbType("varchar", 48, false, "")]
        public string AccessTypeName { get; set; }
    }
}