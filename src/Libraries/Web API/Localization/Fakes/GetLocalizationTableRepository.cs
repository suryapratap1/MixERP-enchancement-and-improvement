// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Localization.Data;
using MixERP.Net.Entities.Localization;

namespace MixERP.Net.Api.Localization.Fakes
{
    public class GetLocalizationTableRepository : IGetLocalizationTableRepository
    {
        public string CultureCode { get; set; }

        public IEnumerable<DbGetLocalizationTableResult> Execute()
        {
            return new List<DbGetLocalizationTableResult>();
        }
    }
}