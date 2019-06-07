// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Policy;
namespace MixERP.Net.Schemas.Policy.Data
{
    public interface IChangePasswordRepository
    {

        int AdminUserId { get; set; }
        string UserName { get; set; }
        string NewPassword { get; set; }

        /// <summary>
        /// Prepares and executes IChangePasswordRepository.
        /// </summary>
        void Execute();
    }
}