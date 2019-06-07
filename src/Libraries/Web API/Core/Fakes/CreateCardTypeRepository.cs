// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CreateCardTypeRepository : ICreateCardTypeRepository
    {
        public int CardTypeId { get; set; }
        public string CardTypeCode { get; set; }
        public string CardTypeName { get; set; }

        public void Execute()
        {
            return;
        }
    }
}