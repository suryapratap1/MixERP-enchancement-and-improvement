// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Audit.Data;
using MixERP.Net.Entities.Audit;

namespace MixERP.Net.Api.Audit.Fakes
{
    public class GetOfficeInformationModelRepository : IGetOfficeInformationModelRepository
    {
        public int PgArg0 { get; set; }

        public IEnumerable<DbGetOfficeInformationModelResult> Execute()
        {
            return new List<DbGetOfficeInformationModelResult>();
        }
    }
}