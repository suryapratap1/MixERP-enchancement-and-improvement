// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.Entities.Policy;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class IsElevatedUserRepository : IIsElevatedUserRepository
    {
        public int UserId { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}