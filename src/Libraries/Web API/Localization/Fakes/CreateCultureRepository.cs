// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Localization.Data;
using MixERP.Net.Entities.Localization;

namespace MixERP.Net.Api.Localization.Fakes
{
    public class CreateCultureRepository : ICreateCultureRepository
    {
        public string CultureCode { get; set; }
        public string CultureName { get; set; }

        public void Execute()
        {
            return;
        }
    }
}