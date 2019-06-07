// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("salesperson_id", autoIncrement = true)]
    [TableName("core.salespersons")]
    [ExplicitColumns]
    public sealed class Salesperson : PetaPocoDB.Record<Salesperson>, IPoco
    {
        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.salespersons_salesperson_id_seq'::regclass)")]
        public int SalespersonId { get; set; }

        [Column("sales_team_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTeamId { get; set; }

        [Column("salesperson_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string SalespersonCode { get; set; }

        [Column("salesperson_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string SalespersonName { get; set; }

        [Column("address")]
        [ColumnDbType("varchar", 100, false, "")]
        public string Address { get; set; }

        [Column("contact_number")]
        [ColumnDbType("varchar", 50, false, "")]
        public string ContactNumber { get; set; }

        [Column("commission_rate")]
        [ColumnDbType("decimal_strict2", 0, false, "0")]
        public decimal CommissionRate { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long AccountId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }
    }
}