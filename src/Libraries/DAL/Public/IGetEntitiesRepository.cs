// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Public;
namespace MixERP.Net.Schemas.Public.Data
{
    public interface IGetEntitiesRepository
    {

        /// <summary>
        /// Prepares and executes IGetEntitiesRepository.
        /// </summary>
        IEnumerable<DbGetEntitiesResult> Execute();
    }
}