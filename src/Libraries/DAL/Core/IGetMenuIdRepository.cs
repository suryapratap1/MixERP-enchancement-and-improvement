// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetMenuIdRepository
    {

        string MenuCode { get; set; }

        /// <summary>
        /// Prepares and executes IGetMenuIdRepository.
        /// </summary>
        int Execute();
    }
}