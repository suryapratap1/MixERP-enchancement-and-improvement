// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICreateMenuLocaleRepository
    {

        int MenuId { get; set; }
        string Culture { get; set; }
        string MenuText { get; set; }

        /// <summary>
        /// Prepares and executes ICreateMenuLocaleRepository.
        /// </summary>
        void Execute();
    }
}