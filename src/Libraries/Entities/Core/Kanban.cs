// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("kanban_id", autoIncrement = true)]
    [TableName("core.kanbans")]
    [ExplicitColumns]
    public sealed class Kanban : PetaPocoDB.Record<Kanban>, IPoco
    {
        [Column("kanban_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.kanbans_kanban_id_seq'::regclass)")]
        public long KanbanId { get; set; }

        [Column("object_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string ObjectName { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("kanban_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string KanbanName { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, true, "")]
        public string Description { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}