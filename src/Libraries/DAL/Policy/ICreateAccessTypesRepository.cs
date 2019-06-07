// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface ICreateAccessTypesRepository
    {

        int AccessTypeId { get; set; }
        string AccessTypeName { get; set; }

        /// <summary>
        /// Prepares and executes ICreateAccessTypesRepository.
        /// </summary>
        void Execute();
    }
}