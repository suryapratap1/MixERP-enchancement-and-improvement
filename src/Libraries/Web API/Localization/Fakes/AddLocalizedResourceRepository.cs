// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Localization.Data;
using MixERP.Net.Entities.Localization;

namespace MixERP.Net.Api.Localization.Fakes
{
    public class AddLocalizedResourceRepository : IAddLocalizedResourceRepository
    {
        public string ResourceClass { get; set; }
        public string CultureCode { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public void Execute()
        {
            return;
        }
    }
}