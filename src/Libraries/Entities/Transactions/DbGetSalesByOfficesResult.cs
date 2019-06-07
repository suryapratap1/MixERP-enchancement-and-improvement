// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_sales_by_offices")]
    [ExplicitColumns]
    public sealed class DbGetSalesByOfficesResult : PetaPocoDB.Record<DbGetSalesByOfficesResult>, IPoco
    {
        [Column("office")]
        [ColumnDbType("text", 0, false, "")]
        public string Office { get; set; }

        [Column("jan")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Jan { get; set; }

        [Column("feb")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Feb { get; set; }

        [Column("mar")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Mar { get; set; }

        [Column("apr")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Apr { get; set; }

        [Column("may")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal May { get; set; }

        [Column("jun")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Jun { get; set; }

        [Column("jul")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Jul { get; set; }

        [Column("aug")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Aug { get; set; }

        [Column("sep")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Sep { get; set; }

        [Column("oct")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Oct { get; set; }

        [Column("nov")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Nov { get; set; }

        [Column("dec")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Dec { get; set; }
    }
}