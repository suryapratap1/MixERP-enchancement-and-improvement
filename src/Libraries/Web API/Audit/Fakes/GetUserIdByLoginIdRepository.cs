// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Audit.Data;
using MixERP.Net.Entities.Audit;

namespace MixERP.Net.Api.Audit.Fakes
{
    public class GetUserIdByLoginIdRepository : IGetUserIdByLoginIdRepository
    {
        public long PgArg0 { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}