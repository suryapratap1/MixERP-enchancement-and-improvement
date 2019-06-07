// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IGetMenuPolicyRepository
    {

        int UserId { get; set; }
        int OfficeId { get; set; }
        string Culture { get; set; }

        /// <summary>
        /// Prepares and executes IGetMenuPolicyRepository.
        /// </summary>
        IEnumerable<DbGetMenuPolicyResult> Execute();
    }
}