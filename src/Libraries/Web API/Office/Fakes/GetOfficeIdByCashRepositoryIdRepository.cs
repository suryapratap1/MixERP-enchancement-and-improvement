// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class GetOfficeIdByCashRepositoryIdRepository : IGetOfficeIdByCashRepositoryIdRepository
    {
        public int CashRepositoryId { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}