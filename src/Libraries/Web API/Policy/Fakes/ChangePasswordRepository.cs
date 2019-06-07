// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.Entities.Policy;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class ChangePasswordRepository : IChangePasswordRepository
    {
        public int AdminUserId { get; set; }
        public string UserName { get; set; }
        public string NewPassword { get; set; }

        public void Execute()
        {
            return;
        }
    }
}