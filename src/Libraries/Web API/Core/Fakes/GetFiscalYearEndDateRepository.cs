// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetFiscalYearEndDateRepository : IGetFiscalYearEndDateRepository
    {
        public int OfficeId { get; set; }

        public DateTime Execute()
        {
            return new DateTime();
        }
    }
}