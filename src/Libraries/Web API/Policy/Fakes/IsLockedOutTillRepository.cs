// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.Entities.Policy;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class IsLockedOutTillRepository : IIsLockedOutTillRepository
    {
        public int UserId { get; set; }

        public DateTime Execute()
        {
            return new DateTime();
        }
    }
}