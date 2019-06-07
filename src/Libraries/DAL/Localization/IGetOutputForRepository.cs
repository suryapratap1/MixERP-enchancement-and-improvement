// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Localization;
namespace MixERP.Net.Schemas.Localization.Data
{
    public interface IGetOutputForRepository
    {

        string CultureCode { get; set; }

        /// <summary>
        /// Prepares and executes IGetOutputForRepository.
        /// </summary>
        string Execute();
    }
}