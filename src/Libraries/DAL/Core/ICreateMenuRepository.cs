// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICreateMenuRepository
    {

        string MenuText { get; set; }
        string Url { get; set; }
        string MenuCode { get; set; }
        int Level { get; set; }
        int ParentMenuId { get; set; }

        /// <summary>
        /// Prepares and executes ICreateMenuRepository.
        /// </summary>
        void Execute();
    }
}