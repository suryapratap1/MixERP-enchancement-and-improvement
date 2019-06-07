// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IIsTransactionRestrictedRepository
    {

        int OfficeId { get; set; }

        /// <summary>
        /// Prepares and executes IIsTransactionRestrictedRepository.
        /// </summary>
        bool Execute();
    }
}