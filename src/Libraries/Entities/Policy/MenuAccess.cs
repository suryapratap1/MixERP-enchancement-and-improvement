// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("access_id", autoIncrement = true)]
    [TableName("policy.menu_access")]
    [ExplicitColumns]
    public sealed class MenuAccess : PetaPocoDB.Record<MenuAccess>, IPoco
    {
        [Column("access_id")]
        [ColumnDbType("int8", 0, false, "nextval('policy.menu_access_access_id_seq'::regclass)")]
        public long AccessId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("menu_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int MenuId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }
    }
}