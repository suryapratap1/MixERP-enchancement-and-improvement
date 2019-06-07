// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Audit;
namespace MixERP.Net.Schemas.Audit.Data
{
    public interface IIsValidLoginIdRepository
    {

        long PgArg0 { get; set; }

        /// <summary>
        /// Prepares and executes IIsValidLoginIdRepository.
        /// </summary>
        bool Execute();
    }
}