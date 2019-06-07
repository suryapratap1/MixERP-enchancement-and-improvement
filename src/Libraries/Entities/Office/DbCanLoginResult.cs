// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("office.can_login")]
    [ExplicitColumns]
    public sealed class DbCanLoginResult : PetaPocoDB.Record<DbCanLoginResult>, IPoco
    {
        [Column("result")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool Result { get; set; }

        [Column("message")]
        [ColumnDbType("text", 0, false, "")]
        public string Message { get; set; }
    }
}