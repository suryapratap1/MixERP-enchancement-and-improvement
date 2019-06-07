// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICreatePaymentCardRepository
    {

        string PaymentCardCode { get; set; }
        string PaymentCardName { get; set; }
        int CardTypeId { get; set; }

        /// <summary>
        /// Prepares and executes ICreatePaymentCardRepository.
        /// </summary>
        void Execute();
    }
}