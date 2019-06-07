// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetSecondRootAccountIdRepository
    {

        long AccountId { get; set; }
        long Parent { get; set; }

        /// <summary>
        /// Prepares and executes IGetSecondRootAccountIdRepository.
        /// </summary>
        int Execute();
    }
}