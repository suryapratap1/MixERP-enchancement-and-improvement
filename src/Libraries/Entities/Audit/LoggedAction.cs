// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Audit
{
    [PrimaryKey("event_id", autoIncrement = true)]
    [TableName("audit.logged_actions")]
    [ExplicitColumns]
    public sealed class LoggedAction : PetaPocoDB.Record<LoggedAction>, IPoco
    {
        [Column("event_id")]
        [ColumnDbType("int8", 0, false, "nextval('audit.logged_actions_event_id_seq'::regclass)")]
        public long EventId { get; set; }

        [Column("schema_name")]
        [ColumnDbType("text", 0, false, "")]
        public string SchemaName { get; set; }

        [Column("table_name")]
        [ColumnDbType("text", 0, false, "")]
        public string TableName { get; set; }

        [Column("relid")]
        [ColumnDbType("oid", 0, false, "")]
        public string Relid { get; set; }

        [Column("session_user_name")]
        [ColumnDbType("text", 0, true, "")]
        public string SessionUserName { get; set; }

        [Column("application_user_name")]
        [ColumnDbType("text", 0, true, "")]
        public string ApplicationUserName { get; set; }

        [Column("action_tstamp_tx")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime ActionTstampTx { get; set; }

        [Column("action_tstamp_stm")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime ActionTstampStm { get; set; }

        [Column("action_tstamp_clk")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime ActionTstampClk { get; set; }

        [Column("transaction_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TransactionId { get; set; }

        [Column("application_name")]
        [ColumnDbType("text", 0, true, "")]
        public string ApplicationName { get; set; }

        [Column("client_addr")]
        [ColumnDbType("inet", 0, true, "")]
        public string ClientAddr { get; set; }

        [Column("client_port")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ClientPort { get; set; }

        [Column("client_query")]
        [ColumnDbType("text", 0, true, "")]
        public string ClientQuery { get; set; }

        [Column("action")]
        [ColumnDbType("text", 0, false, "")]
        public string Action { get; set; }

        [Column("row_data")]
        [ColumnDbType("hstore", 0, true, "")]
        public string RowData { get; set; }

        [Column("changed_fields")]
        [ColumnDbType("hstore", 0, true, "")]
        public string ChangedFields { get; set; }

        [Column("statement_only")]
        [ColumnDbType("bool", 0, false, "")]
        public bool StatementOnly { get; set; }
    }
}