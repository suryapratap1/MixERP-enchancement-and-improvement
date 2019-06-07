// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IIsLockedOutTillRepository
    {

        int UserId { get; set; }

        /// <summary>
        /// Prepares and executes IIsLockedOutTillRepository.
        /// </summary>
        DateTime Execute();
    }
}