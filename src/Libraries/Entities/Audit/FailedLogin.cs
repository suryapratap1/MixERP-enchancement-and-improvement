// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Audit
{
    [PrimaryKey("failed_login_id", autoIncrement = true)]
    [TableName("audit.failed_logins")]
    [ExplicitColumns]
    public sealed class FailedLogin : PetaPocoDB.Record<FailedLogin>, IPoco
    {
        [Column("failed_login_id")]
        [ColumnDbType("int8", 0, false, "nextval('audit.failed_logins_failed_login_id_seq'::regclass)")]
        public long FailedLoginId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("user_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string UserName { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("browser")]
        [ColumnDbType("varchar", 500, false, "")]
        public string Browser { get; set; }

        [Column("ip_address")]
        [ColumnDbType("varchar", 50, false, "")]
        public string IpAddress { get; set; }

        [Column("failed_date_time")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime FailedDateTime { get; set; }

        [Column("remote_user")]
        [ColumnDbType("varchar", 50, false, "")]
        public string RemoteUser { get; set; }

        [Column("details")]
        [ColumnDbType("varchar", 250, true, "")]
        public string Details { get; set; }
    }
}