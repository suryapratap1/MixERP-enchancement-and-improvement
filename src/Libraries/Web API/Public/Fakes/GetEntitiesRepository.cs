// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Public.Data;
using MixERP.Net.Entities.Public;

namespace MixERP.Net.Api.Public.Fakes
{
    public class GetEntitiesRepository : IGetEntitiesRepository
    {

        public IEnumerable<DbGetEntitiesResult> Execute()
        {
            return new List<DbGetEntitiesResult>();
        }
    }
}