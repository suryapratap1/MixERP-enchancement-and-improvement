// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetStateIdByShippingAddressCodeRepository
    {

        string PgArg0 { get; set; }
        long PgArg1 { get; set; }

        /// <summary>
        /// Prepares and executes IGetStateIdByShippingAddressCodeRepository.
        /// </summary>
        int Execute();
    }
}