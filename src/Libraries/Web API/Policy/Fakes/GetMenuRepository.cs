// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.Entities.Policy;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class GetMenuRepository : IGetMenuRepository
    {
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public string Culture { get; set; }

        public IEnumerable<DbGetMenuResult> Execute()
        {
            return new List<DbGetMenuResult>();
        }
    }
}