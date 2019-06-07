// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Office;
namespace MixERP.Net.Schemas.Office.Data
{
    public interface IValidateLoginRepository
    {

        string UserName { get; set; }
        string Password { get; set; }
        string Challenge { get; set; }

        /// <summary>
        /// Prepares and executes IValidateLoginRepository.
        /// </summary>
        bool Execute();
    }
}