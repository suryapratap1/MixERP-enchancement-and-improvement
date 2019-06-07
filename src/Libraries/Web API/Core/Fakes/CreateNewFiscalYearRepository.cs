// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CreateNewFiscalYearRepository : ICreateNewFiscalYearRepository
    {
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public string FiscalYearCode { get; set; }
        public string FiscalYearName { get; set; }

        public void Execute()
        {
            return;
        }
    }
}