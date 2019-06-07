// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Audit.Data;
using MixERP.Net.Entities.Audit;

namespace MixERP.Net.Api.Audit.Fakes
{
    public class IsValidLoginIdRepository : IIsValidLoginIdRepository
    {
        public long PgArg0 { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}