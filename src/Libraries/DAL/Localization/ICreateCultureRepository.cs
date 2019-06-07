// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Localization;
namespace MixERP.Net.Schemas.Localization.Data
{
    public interface ICreateCultureRepository
    {

        string CultureCode { get; set; }
        string CultureName { get; set; }

        /// <summary>
        /// Prepares and executes ICreateCultureRepository.
        /// </summary>
        void Execute();
    }
}