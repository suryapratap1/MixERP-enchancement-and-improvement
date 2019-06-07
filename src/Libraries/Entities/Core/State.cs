// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("state_id", autoIncrement = true)]
    [TableName("core.states")]
    [ExplicitColumns]
    public sealed class State : PetaPocoDB.Record<State>, IPoco
    {
        [Column("state_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.states_state_id_seq'::regclass)")]
        public int StateId { get; set; }

        [Column("country_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CountryId { get; set; }

        [Column("state_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string StateCode { get; set; }

        [Column("state_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string StateName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}