// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetAssociatedUnitsRepository : IGetAssociatedUnitsRepository
    {
        public int PgArg0 { get; set; }

        public IEnumerable<DbGetAssociatedUnitsResult> Execute()
        {
            return new List<DbGetAssociatedUnitsResult>();
        }
    }
}