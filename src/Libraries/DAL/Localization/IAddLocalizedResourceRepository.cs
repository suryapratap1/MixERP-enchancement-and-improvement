// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Localization;
namespace MixERP.Net.Schemas.Localization.Data
{
    public interface IAddLocalizedResourceRepository
    {

        string ResourceClass { get; set; }
        string CultureCode { get; set; }
        string Key { get; set; }
        string Value { get; set; }

        /// <summary>
        /// Prepares and executes IAddLocalizedResourceRepository.
        /// </summary>
        void Execute();
    }
}