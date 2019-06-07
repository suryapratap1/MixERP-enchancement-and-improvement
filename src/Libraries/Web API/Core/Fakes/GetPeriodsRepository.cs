// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetPeriodsRepository : IGetPeriodsRepository
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public IEnumerable<MixERP.Net.Entities.Core.Period> Execute()
        {
            return new List<MixERP.Net.Entities.Core.Period>();
        }
    }
}