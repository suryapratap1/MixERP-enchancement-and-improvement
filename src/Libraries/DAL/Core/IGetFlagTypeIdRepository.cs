// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetFlagTypeIdRepository
    {

        int UserId { get; set; }
        string Resource { get; set; }
        string ResourceKey { get; set; }
        string ResourceId { get; set; }

        /// <summary>
        /// Prepares and executes IGetFlagTypeIdRepository.
        /// </summary>
        int Execute();
    }
}