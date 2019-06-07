// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("flag_id", autoIncrement = true)]
    [TableName("core.flags")]
    [ExplicitColumns]
    public sealed class Flag : PetaPocoDB.Record<Flag>, IPoco
    {
        [Column("flag_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.flags_flag_id_seq'::regclass)")]
        public long FlagId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("flag_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int FlagTypeId { get; set; }

        [Column("resource")]
        [ColumnDbType("text", 0, true, "")]
        public string Resource { get; set; }

        [Column("resource_key")]
        [ColumnDbType("text", 0, true, "")]
        public string ResourceKey { get; set; }

        [Column("resource_id")]
        [ColumnDbType("text", 0, true, "")]
        public string ResourceId { get; set; }

        [Column("flagged_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? FlaggedOn { get; set; }
    }
}