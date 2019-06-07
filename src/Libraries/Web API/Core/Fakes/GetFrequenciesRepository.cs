// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetFrequenciesRepository : IGetFrequenciesRepository
    {
        public int FrequencyId { get; set; }

        public IEnumerable<int> Execute()
        {
            return new List<int>();
        }
    }
}