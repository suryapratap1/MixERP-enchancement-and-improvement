// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("education_level_id", autoIncrement = true)]
    [TableName("hrm.education_levels")]
    [ExplicitColumns]
    public sealed class EducationLevel : PetaPocoDB.Record<EducationLevel>, IPoco
    {
        [Column("education_level_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.education_levels_education_level_id_seq'::regclass)")]
        public int EducationLevelId { get; set; }

        [Column("education_level_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string EducationLevelName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}