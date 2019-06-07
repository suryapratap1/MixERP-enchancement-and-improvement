// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetPeriodsRepository
    {

        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }

        /// <summary>
        /// Prepares and executes IGetPeriodsRepository.
        /// </summary>
        IEnumerable<MixERP.Net.Entities.Core.Period> Execute();
    }
}