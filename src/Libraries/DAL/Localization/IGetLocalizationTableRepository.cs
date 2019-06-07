// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Localization;
namespace MixERP.Net.Schemas.Localization.Data
{
    public interface IGetLocalizationTableRepository
    {

        string CultureCode { get; set; }

        /// <summary>
        /// Prepares and executes IGetLocalizationTableRepository.
        /// </summary>
        IEnumerable<DbGetLocalizationTableResult> Execute();
    }
}