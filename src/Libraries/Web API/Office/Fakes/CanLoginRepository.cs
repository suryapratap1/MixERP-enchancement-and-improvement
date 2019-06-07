// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class CanLoginRepository : ICanLoginRepository
    {
        public int UserId { get; set; }
        public int OfficeId { get; set; }

        public IEnumerable<DbCanLoginResult> Execute()
        {
            return new List<DbCanLoginResult>();
        }
    }
}