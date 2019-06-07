// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetCustomFieldDefinitionRepository
    {

        string TableName { get; set; }
        string ResourceId { get; set; }

        /// <summary>
        /// Prepares and executes IGetCustomFieldDefinitionRepository.
        /// </summary>
        IEnumerable<DbGetCustomFieldDefinitionResult> Execute();
    }
}