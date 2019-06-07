// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetFlagTypeIdRepository : IGetFlagTypeIdRepository
    {
        public int UserId { get; set; }
        public string Resource { get; set; }
        public string ResourceKey { get; set; }
        public string ResourceId { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}