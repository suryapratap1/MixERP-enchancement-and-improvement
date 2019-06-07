// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetFrequencyEndDateRepository
    {

        int FrequencyId { get; set; }
        DateTime ValueDate { get; set; }

        /// <summary>
        /// Prepares and executes IGetFrequencyEndDateRepository.
        /// </summary>
        DateTime Execute();
    }
}