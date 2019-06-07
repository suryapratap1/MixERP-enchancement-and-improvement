// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class GetOfficeIdsRepository : IGetOfficeIdsRepository
    {
        public int RootOfficeId { get; set; }

        public IEnumerable<int> Execute()
        {
            return new List<int>();
        }
    }
}