// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("job_title_id", autoIncrement = true)]
    [TableName("hrm.job_titles")]
    [ExplicitColumns]
    public sealed class JobTitle : PetaPocoDB.Record<JobTitle>, IPoco
    {
        [Column("job_title_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.job_titles_job_title_id_seq'::regclass)")]
        public int JobTitleId { get; set; }

        [Column("job_title_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string JobTitleCode { get; set; }

        [Column("job_title_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string JobTitleName { get; set; }

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