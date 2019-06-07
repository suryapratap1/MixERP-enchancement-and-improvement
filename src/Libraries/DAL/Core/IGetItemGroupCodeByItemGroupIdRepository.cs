// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetItemGroupCodeByItemGroupIdRepository
    {

        int PgArg0 { get; set; }

        /// <summary>
        /// Prepares and executes IGetItemGroupCodeByItemGroupIdRepository.
        /// </summary>
        string Execute();
    }
}