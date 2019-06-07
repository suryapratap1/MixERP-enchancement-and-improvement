// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CalculateInterestRepository : ICalculateInterestRepository
    {
        public decimal Principal { get; set; }
        public decimal Rate { get; set; }
        public int Days { get; set; }
        public int RoundUp { get; set; }
        public int NumOfDaysInYear { get; set; }

        public decimal Execute()
        {
            return 1;
        }
    }
}