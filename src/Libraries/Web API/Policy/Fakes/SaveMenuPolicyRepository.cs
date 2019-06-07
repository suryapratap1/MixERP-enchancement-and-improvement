// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.Entities.Policy;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class SaveMenuPolicyRepository : ISaveMenuPolicyRepository
    {
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public int[] MenuIds { get; set; }

        public void Execute()
        {
            return;
        }
    }
}