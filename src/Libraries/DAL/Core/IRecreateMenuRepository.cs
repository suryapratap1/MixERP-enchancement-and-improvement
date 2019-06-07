// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface IRecreateMenuRepository
    {

        string MenuText { get; set; }
        string Url { get; set; }
        string MenuCode { get; set; }
        int Level { get; set; }
        int ParentMenuId { get; set; }

        /// <summary>
        /// Prepares and executes IRecreateMenuRepository.
        /// </summary>
        void Execute();
    }
}