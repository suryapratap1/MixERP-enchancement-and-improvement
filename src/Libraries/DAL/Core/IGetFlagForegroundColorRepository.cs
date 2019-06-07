// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetFlagForegroundColorRepository
    {

        int FlagTypeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetFlagForegroundColorRepository.
        /// </summary>
        string Execute();
    }
}