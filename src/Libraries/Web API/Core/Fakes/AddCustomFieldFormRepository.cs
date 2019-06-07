// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class AddCustomFieldFormRepository : IAddCustomFieldFormRepository
    {
        public string FormName { get; set; }
        public string TableName { get; set; }
        public string KeyName { get; set; }

        public void Execute()
        {
            return;
        }
    }
}