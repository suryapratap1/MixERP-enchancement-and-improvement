// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Public
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("public.db_stat")]
    [ExplicitColumns]
    public sealed class DbStat : PetaPocoDB.Record<DbStat>, IPoco
    {
        [Column("relname")]
        [ColumnDbType("name", 0, true, "")]
        public string Relname { get; set; }

        [Column("last_vacuum")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? LastVacuum { get; set; }

        [Column("last_autovacuum")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? LastAutovacuum { get; set; }

        [Column("last_analyze")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? LastAnalyze { get; set; }

        [Column("last_autoanalyze")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? LastAutoanalyze { get; set; }

        [Column("vacuum_count")]
        [ColumnDbType("int8", 0, true, "")]
        public long? VacuumCount { get; set; }

        [Column("autovacuum_count")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AutovacuumCount { get; set; }

        [Column("analyze_count")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AnalyzeCount { get; set; }

        [Column("autoanalyze_count")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AutoanalyzeCount { get; set; }
    }
}