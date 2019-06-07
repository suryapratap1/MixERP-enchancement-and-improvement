// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetPartyIdByPartyCodeRepository : IGetPartyIdByPartyCodeRepository
    {
        public string PgArg0 { get; set; }

        public long Execute()
        {
            return 1;
        }
    }
}