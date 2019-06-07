// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetStateIdByShippingAddressCodeRepository : IGetStateIdByShippingAddressCodeRepository
    {
        public string PgArg0 { get; set; }
        public long PgArg1 { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}