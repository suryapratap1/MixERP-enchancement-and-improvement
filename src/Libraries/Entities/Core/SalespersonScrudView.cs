// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.salesperson_scrud_view")]
    [ExplicitColumns]
    public sealed class SalespersonScrudView : PetaPocoDB.Record<SalespersonScrudView>, IPoco
    {
        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalespersonId { get; set; }

        [Column("sales_team")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTeam { get; set; }

        [Column("salesperson_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string SalespersonCode { get; set; }

        [Column("salesperson_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string SalespersonName { get; set; }

        [Column("address")]
        [ColumnDbType("varchar", 100, true, "")]
        public string Address { get; set; }

        [Column("contact_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ContactNumber { get; set; }

        [Column("commission_rate")]
        [ColumnDbType("decimal_strict2", 0, true, "")]
        public decimal? CommissionRate { get; set; }

        [Column("account")]
        [ColumnDbType("text", 0, true, "")]
        public string Account { get; set; }

        [Column("photo")]
        [ColumnDbType("image", 0, true, "")]
        public string Photo { get; set; }
    }
}