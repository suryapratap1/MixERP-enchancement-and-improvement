// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.Entities.Office;

namespace MixERP.Net.Api.Office.Fakes
{
    public class HasChildOfficesRepository : IHasChildOfficesRepository
    {
        public int OfficeId { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}