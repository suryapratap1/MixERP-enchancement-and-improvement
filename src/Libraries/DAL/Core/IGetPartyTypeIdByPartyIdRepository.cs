// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetPartyTypeIdByPartyIdRepository
    {

        long PartyId { get; set; }

        /// <summary>
        /// Prepares and executes IGetPartyTypeIdByPartyIdRepository.
        /// </summary>
        int Execute();
    }
}