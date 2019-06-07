// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetFlagBackgroundColorRepository : IGetFlagBackgroundColorRepository
    {
        public int FlagTypeId { get; set; }

        public string Execute()
        {
            return "FizzBuzz";
        }
    }
}