// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class IsParentOfficeRepository : IIsParentOfficeRepository
    {
        public int Parent { get; set; }
        public int Child { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}