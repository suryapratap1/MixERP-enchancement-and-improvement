// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Localization.Data;
using MixERP.Net.Entities.Localization;

namespace MixERP.Net.Api.Localization.Fakes
{
    public class GetOutputForRepository : IGetOutputForRepository
    {
        public string CultureCode { get; set; }

        public string Execute()
        {
            return "FizzBuzz";
        }
    }
}