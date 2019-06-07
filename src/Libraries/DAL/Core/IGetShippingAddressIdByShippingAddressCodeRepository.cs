// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IGetShippingAddressIdByShippingAddressCodeRepository
    {

        string PgArg0 { get; set; }
        long PgArg1 { get; set; }

        /// <summary>
        /// Prepares and executes IGetShippingAddressIdByShippingAddressCodeRepository.
        /// </summary>
        int Execute();
    }
}