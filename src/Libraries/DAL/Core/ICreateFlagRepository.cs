// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICreateFlagRepository
    {

        int UserId { get; set; }
        int FlagTypeId { get; set; }
        string Resource { get; set; }
        string ResourceKey { get; set; }
        string ResourceId { get; set; }

        /// <summary>
        /// Prepares and executes ICreateFlagRepository.
        /// </summary>
        void Execute();
    }
}