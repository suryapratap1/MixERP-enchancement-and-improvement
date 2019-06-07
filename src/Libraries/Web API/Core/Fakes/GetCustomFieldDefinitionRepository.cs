// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class GetCustomFieldDefinitionRepository : IGetCustomFieldDefinitionRepository
    {
        public string TableName { get; set; }
        public string ResourceId { get; set; }

        public IEnumerable<DbGetCustomFieldDefinitionResult> Execute()
        {
            return new List<DbGetCustomFieldDefinitionResult>();
        }
    }
}