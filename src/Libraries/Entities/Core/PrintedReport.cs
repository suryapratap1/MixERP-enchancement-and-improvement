// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("id", autoIncrement = true)]
    [TableName("core.printed_reports")]
    [ExplicitColumns]
    public sealed class PrintedReport : PetaPocoDB.Record<PrintedReport>, IPoco
    {
        [Column("id")]
        [ColumnDbType("int8", 0, false, "nextval('core.printed_reports_id_seq'::regclass)")]
        public long Id { get; set; }

        [Column("report_title")]
        [ColumnDbType("varchar", 100, false, "")]
        public string ReportTitle { get; set; }

        [Column("tran_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long TranId { get; set; }

        [Column("description")]
        [ColumnDbType("varchar", 200,true , "")]
        public string Description { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}