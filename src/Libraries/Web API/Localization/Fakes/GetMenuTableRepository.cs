// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Localization.Data;
using MixERP.Net.Entities.Localization;

namespace MixERP.Net.Api.Localization.Fakes
{
    public class GetMenuTableRepository : IGetMenuTableRepository
    {
        public string CultureCode { get; set; }

        public IEnumerable<DbGetMenuTableResult> Execute()
        {
            return new List<DbGetMenuTableResult>();
        }
    }
}