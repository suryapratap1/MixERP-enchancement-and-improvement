// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetAssociatedUnitsFromItemCodeRepository : IGetAssociatedUnitsFromItemCodeRepository
    {
        public string PgArg0 { get; set; }

        public IEnumerable<DbGetAssociatedUnitsFromItemCodeResult> Execute()
        {
            return new List<DbGetAssociatedUnitsFromItemCodeResult>();
        }
    }
}