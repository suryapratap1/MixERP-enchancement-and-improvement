// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CreateFlagRepository : ICreateFlagRepository
    {
        public int UserId { get; set; }
        public int FlagTypeId { get; set; }
        public string Resource { get; set; }
        public string ResourceKey { get; set; }
        public string ResourceId { get; set; }

        public void Execute()
        {
            return;
        }
    }
}