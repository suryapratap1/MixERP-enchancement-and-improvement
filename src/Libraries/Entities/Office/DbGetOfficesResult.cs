// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("office.get_offices")]
    [ExplicitColumns]
    public sealed class DbGetOfficesResult : PetaPocoDB.Record<DbGetOfficesResult>, IPoco
    {
        [Column("office_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("office_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string OfficeCode { get; set; }

        [Column("office_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string OfficeName { get; set; }

        [Column("address")]
        [ColumnDbType("text", 0, false, "")]
        public string Address { get; set; }
    }
}