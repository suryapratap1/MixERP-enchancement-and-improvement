// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface ISaveMenuPolicyRepository
    {

        int UserId { get; set; }
        int OfficeId { get; set; }
        int[] MenuIds { get; set; }

        /// <summary>
        /// Prepares and executes ISaveMenuPolicyRepository.
        /// </summary>
        void Execute();
    }
}