// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICreateItemVariantRepository
    {

        int VariantOf { get; set; }
        int ItemId { get; set; }
        string ItemCode { get; set; }
        string ItemName { get; set; }
        int[] VariantIds { get; set; }
        int UserId { get; set; }

        /// <summary>
        /// Prepares and executes ICreateItemVariantRepository.
        /// </summary>
        int Execute();
    }
}