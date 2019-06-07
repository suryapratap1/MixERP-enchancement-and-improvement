// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetLocaleRepository : IGetLocaleRepository
    {

        public string Execute()
        {
            return "FizzBuzz";
        }
    }
}