// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetBaseQuantityByUnitNameRepository : IGetBaseQuantityByUnitNameRepository
    {
        public string PgArg0 { get; set; }
        public int PgArg1 { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}