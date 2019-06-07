// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class GetIncomeTaxRateRepository : IGetIncomeTaxRateRepository
    {
        public int OfficeId { get; set; }

        public float Execute()
        {
            return 1;
        }
    }
}