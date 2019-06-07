// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IAddCustomFieldFormRepository
    {

        string FormName { get; set; }
        string TableName { get; set; }
        string KeyName { get; set; }

        /// <summary>
        /// Prepares and executes IAddCustomFieldFormRepository.
        /// </summary>
        void Execute();
    }
}