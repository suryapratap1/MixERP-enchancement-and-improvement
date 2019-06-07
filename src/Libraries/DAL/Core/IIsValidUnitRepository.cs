// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IIsValidUnitRepository
    {

        int ItemId { get; set; }
        int UnitId { get; set; }

        /// <summary>
        /// Prepares and executes IIsValidUnitRepository.
        /// </summary>
        bool Execute();
    }
}