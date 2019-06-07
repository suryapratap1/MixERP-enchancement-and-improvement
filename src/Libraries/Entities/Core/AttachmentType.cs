using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.attachment_type")]
    [ExplicitColumns]
    public sealed class AttachmentType : PetaPocoDB.Record<AttachmentType>, IPoco
    {
        [Column("comment")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Comment { get; set; }

        [Column("file_path")]
        [ColumnDbType("text", 0, false, "")]
        public string FilePath { get; set; }

        [Column("original_file_name")]
        [ColumnDbType("text", 0, false, "")]
        public string OriginalFileName { get; set; }

        [Column("file_extension")]
        [ColumnDbType("text", 0, false, "")]
        public string FileExtension { get; set; }
    }
}