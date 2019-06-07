// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetCustomFieldSetupIdByTableNameRepository
    {

        string TableName { get; set; }
        string FieldName { get; set; }

        /// <summary>
        /// Prepares and executes IGetCustomFieldSetupIdByTableNameRepository.
        /// </summary>
        int Execute();
    }
}