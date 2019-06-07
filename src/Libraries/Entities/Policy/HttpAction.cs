// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("http_action_code", autoIncrement = false)]
    [TableName("policy.http_actions")]
    [ExplicitColumns]
    public sealed class HttpAction : PetaPocoDB.Record<HttpAction>, IPoco
    {
        [Column("http_action_code")]
        [ColumnDbType("text", 0, false, "")]
        public string HttpActionCode { get; set; }
    }
}