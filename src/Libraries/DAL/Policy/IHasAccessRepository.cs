// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IHasAccessRepository
    {

        int UserId { get; set; }
        string Entity { get; set; }
        int AccessTypeId { get; set; }

        /// <summary>
        /// Prepares and executes IHasAccessRepository.
        /// </summary>
        bool Execute();
    }
}