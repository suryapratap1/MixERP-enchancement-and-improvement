// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.Entities.Policy;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class HasAccessRepository : IHasAccessRepository
    {
        public int UserId { get; set; }
        public string Entity { get; set; }
        public int AccessTypeId { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}