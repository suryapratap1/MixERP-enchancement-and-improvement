// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICalculateInterestRepository
    {

        decimal Principal { get; set; }
        decimal Rate { get; set; }
        int Days { get; set; }
        int RoundUp { get; set; }
        int NumOfDaysInYear { get; set; }

        /// <summary>
        /// Prepares and executes ICalculateInterestRepository.
        /// </summary>
        decimal Execute();
    }
}