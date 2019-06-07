// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("flag_type_id", autoIncrement = true)]
    [TableName("core.flag_types")]
    [ExplicitColumns]
    public sealed class FlagType : PetaPocoDB.Record<FlagType>, IPoco
    {
        [Column("flag_type_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.flag_types_flag_type_id_seq'::regclass)")]
        public int FlagTypeId { get; set; }

        [Column("flag_type_name")]
        [ColumnDbType("varchar", 24, false, "")]
        public string FlagTypeName { get; set; }

        [Column("background_color")]
        [ColumnDbType("color", 0, false, "")]
        public string BackgroundColor { get; set; }

        [Column("foreground_color")]
        [ColumnDbType("color", 0, false, "")]
        public string ForegroundColor { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}