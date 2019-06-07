// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IIsParentUnitRepository
    {

        int Parent { get; set; }
        int Child { get; set; }

        /// <summary>
        /// Prepares and executes IIsParentUnitRepository.
        /// </summary>
        bool Execute();
    }
}