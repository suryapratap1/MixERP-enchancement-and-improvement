// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetFrequencyEndDateRepository : IGetFrequencyEndDateRepository
    {
        public int FrequencyId { get; set; }
        public DateTime ValueDate { get; set; }

        public DateTime Execute()
        {
            return new DateTime();
        }
    }
}