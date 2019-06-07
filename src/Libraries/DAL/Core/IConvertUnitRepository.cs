// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IConvertUnitRepository
    {

        int FromUnit { get; set; }
        int ToUnit { get; set; }

        /// <summary>
        /// Prepares and executes IConvertUnitRepository.
        /// </summary>
        decimal Execute();
    }
}