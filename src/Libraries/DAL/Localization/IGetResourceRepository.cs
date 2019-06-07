// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Localization;
namespace MixERP.Net.Schemas.Localization.Data
{
    public interface IGetResourceRepository
    {

        string CultureCode { get; set; }
        string ResourceClass { get; set; }
        string Key { get; set; }

        /// <summary>
        /// Prepares and executes IGetResourceRepository.
        /// </summary>
        string Execute();
    }
}