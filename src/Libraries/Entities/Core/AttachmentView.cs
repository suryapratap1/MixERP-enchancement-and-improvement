// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.attachment_view")]
    [ExplicitColumns]
    public sealed class AttachmentView : PetaPocoDB.Record<AttachmentView>, IPoco
    {
        [Column("attachment_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AttachmentId { get; set; }

        [Column("book")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Book { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("resource")]
        [ColumnDbType("text", 0, true, "")]
        public string Resource { get; set; }

        [Column("resource_key")]
        [ColumnDbType("text", 0, true, "")]
        public string ResourceKey { get; set; }

        [Column("resource_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ResourceId { get; set; }

        [Column("original_file_name")]
        [ColumnDbType("text", 0, true, "")]
        public string OriginalFileName { get; set; }

        [Column("file_extension")]
        [ColumnDbType("varchar", 12, true, "")]
        public string FileExtension { get; set; }

        [Column("file_path")]
        [ColumnDbType("text", 0, true, "")]
        public string FilePath { get; set; }

        [Column("comment")]
        [ColumnDbType("varchar", 96, true, "")]
        public string Comment { get; set; }

        [Column("added_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AddedOn { get; set; }
    }
}