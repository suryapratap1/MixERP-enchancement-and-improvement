// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetBaseQuantityByUnitNameRepository
    {

        string PgArg0 { get; set; }
        int PgArg1 { get; set; }

        /// <summary>
        /// Prepares and executes IGetBaseQuantityByUnitNameRepository.
        /// </summary>
        decimal Execute();
    }
}