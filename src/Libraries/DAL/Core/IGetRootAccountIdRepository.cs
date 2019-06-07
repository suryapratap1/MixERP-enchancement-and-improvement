// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetRootAccountIdRepository
    {

        long AccountId { get; set; }
        long Parent { get; set; }

        /// <summary>
        /// Prepares and executes IGetRootAccountIdRepository.
        /// </summary>
        int Execute();
    }
}