// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Localization
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("localization.get_localization_table")]
    [ExplicitColumns]
    public sealed class DbGetLocalizationTableResult : PetaPocoDB.Record<DbGetLocalizationTableResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long Id { get; set; }

        [Column("resource_class")]
        [ColumnDbType("text", 0, false, "")]
        public string ResourceClass { get; set; }

        [Column("key")]
        [ColumnDbType("text", 0, false, "")]
        public string Key { get; set; }

        [Column("original")]
        [ColumnDbType("text", 0, false, "")]
        public string Original { get; set; }

        [Column("translated")]
        [ColumnDbType("text", 0, false, "")]
        public string Translated { get; set; }
    }
}