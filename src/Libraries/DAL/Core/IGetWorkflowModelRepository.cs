// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetWorkflowModelRepository
    {

        /// <summary>
        /// Prepares and executes IGetWorkflowModelRepository.
        /// </summary>
        IEnumerable<DbGetWorkflowModelResult> Execute();
    }
}