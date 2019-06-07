// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.Entities.Policy;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class CreateAccessTypesRepository : ICreateAccessTypesRepository
    {
        public int AccessTypeId { get; set; }
        public string AccessTypeName { get; set; }

        public void Execute()
        {
            return;
        }
    }
}