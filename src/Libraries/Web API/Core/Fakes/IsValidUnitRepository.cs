// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class IsValidUnitRepository : IIsValidUnitRepository
    {
        public int ItemId { get; set; }
        public int UnitId { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}