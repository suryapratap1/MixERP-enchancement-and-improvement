// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface IIsParentOfficeRepository
    {

        int Parent { get; set; }
        int Child { get; set; }

        /// <summary>
        /// Prepares and executes IIsParentOfficeRepository.
        /// </summary>
        bool Execute();
    }
}