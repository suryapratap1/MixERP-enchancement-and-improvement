// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CreateMenuLocaleRepository : ICreateMenuLocaleRepository
    {
        public int MenuId { get; set; }
        public string Culture { get; set; }
        public string MenuText { get; set; }

        public void Execute()
        {
            return;
        }
    }
}