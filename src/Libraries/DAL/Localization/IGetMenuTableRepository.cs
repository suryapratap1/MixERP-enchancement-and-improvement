// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Localization;
namespace MixERP.Net.Schemas.Localization.Data
{
    public interface IGetMenuTableRepository
    {

        string CultureCode { get; set; }

        /// <summary>
        /// Prepares and executes IGetMenuTableRepository.
        /// </summary>
        IEnumerable<DbGetMenuTableResult> Execute();
    }
}