// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class AppendIfNotNullRepository : IAppendIfNotNullRepository
    {
        public string Source { get; set; }
        public string ToAppend { get; set; }

        public string Execute()
        {
            return "FizzBuzz";
        }
    }
}