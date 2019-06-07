// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("attachment_lookup_id", autoIncrement = true)]
    [TableName("core.attachment_lookup")]
    [ExplicitColumns]
    public sealed class AttachmentLookup : PetaPocoDB.Record<AttachmentLookup>, IPoco
    {
        [Column("attachment_lookup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.attachment_lookup_attachment_lookup_id_seq'::regclass)")]
        public int AttachmentLookupId { get; set; }

        [Column("book")]
        [ColumnDbType("varchar", 50, false, "")]
        public string Book { get; set; }

        [Column("resource")]
        [ColumnDbType("text", 0, false, "")]
        public string Resource { get; set; }

        [Column("resource_key")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceKey { get; set; }
    }
}