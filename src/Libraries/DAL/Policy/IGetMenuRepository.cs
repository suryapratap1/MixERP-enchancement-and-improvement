// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IGetMenuRepository
    {

        int UserId { get; set; }
        int OfficeId { get; set; }
        string Culture { get; set; }

        /// <summary>
        /// Prepares and executes IGetMenuRepository.
        /// </summary>
        IEnumerable<DbGetMenuResult> Execute();
    }
}