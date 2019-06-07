// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetAccountViewByAccountMasterIdRepository : IGetAccountViewByAccountMasterIdRepository
    {
        public int AccountMasterId { get; set; }
        public int RowNumber { get; set; }

        public IEnumerable<DbGetAccountViewByAccountMasterIdResult> Execute()
        {
            return new List<DbGetAccountViewByAccountMasterIdResult>();
        }
    }
}