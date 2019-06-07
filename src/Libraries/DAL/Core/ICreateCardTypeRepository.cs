// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICreateCardTypeRepository
    {

        int CardTypeId { get; set; }
        string CardTypeCode { get; set; }
        string CardTypeName { get; set; }

        /// <summary>
        /// Prepares and executes ICreateCardTypeRepository.
        /// </summary>
        void Execute();
    }
}