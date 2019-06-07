// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("office.sign_in")]
    [ExplicitColumns]
    public sealed class DbSignInResult : PetaPocoDB.Record<DbSignInResult>, IPoco
    {
        [Column("login_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long LoginId { get; set; }

        [Column("message")]
        [ColumnDbType("text", 0, false, "")]
        public string Message { get; set; }
    }
}