// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("marital_status_id", autoIncrement = true)]
    [TableName("core.marital_statuses")]
    [ExplicitColumns]
    public sealed class MaritalStatus : PetaPocoDB.Record<MaritalStatus>, IPoco
    {
        [Column("marital_status_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.marital_statuses_marital_status_id_seq'::regclass)")]
        public int MaritalStatusId { get; set; }

        [Column("marital_status_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string MaritalStatusCode { get; set; }

        [Column("marital_status_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string MaritalStatusName { get; set; }

        [Column("is_legally_recognized_marriage")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsLegallyRecognizedMarriage { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}