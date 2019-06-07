// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class GetCashRepositoryIdByCashRepositoryNameRepository : IGetCashRepositoryIdByCashRepositoryNameRepository
    {
        public string CashRepositoryName { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}