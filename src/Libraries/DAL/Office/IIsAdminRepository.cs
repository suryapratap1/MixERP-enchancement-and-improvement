// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface IIsAdminRepository
    {

        int UserId { get; set; }

        /// <summary>
        /// Prepares and executes IIsAdminRepository.
        /// </summary>
        bool Execute();
    }
}