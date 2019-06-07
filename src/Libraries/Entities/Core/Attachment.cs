// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("attachment_id", autoIncrement = true)]
    [TableName("core.attachments")]
    [ExplicitColumns]
    public sealed class Attachment : PetaPocoDB.Record<Attachment>, IPoco
    {
        [Column("attachment_id")]
        [ColumnDbType("int8", 0, false, "nextval('core.attachments_attachment_id_seq'::regclass)")]
        public long AttachmentId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("resource")]
        [ColumnDbType("text", 0, false, "")]
        public string Resource { get; set; }

        [Column("resource_key")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceKey { get; set; }

        [Column("resource_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long ResourceId { get; set; }

        [Column("original_file_name")]
        [ColumnDbType("text", 0, false, "")]
        public string OriginalFileName { get; set; }

        [Column("file_extension")]
        [ColumnDbType("varchar", 12, false, "")]
        public string FileExtension { get; set; }

        [Column("file_path")]
        [ColumnDbType("text", 0, false, "")]
        public string FilePath { get; set; }

        [Column("comment")]
        [ColumnDbType("varchar", 96, false, "")]
        public string Comment { get; set; }

        [Column("added_on")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime AddedOn { get; set; }
    }
}