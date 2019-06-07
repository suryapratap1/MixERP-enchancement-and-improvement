// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class GetStoresRepository : IGetStoresRepository
    {
        public int OfficeId { get; set; }
        public int UserId { get; set; }

        public IEnumerable<DbGetStoresResult> Execute()
        {
            return new List<DbGetStoresResult>();
        }
    }
}