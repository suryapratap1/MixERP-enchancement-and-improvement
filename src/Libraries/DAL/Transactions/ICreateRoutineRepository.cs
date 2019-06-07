// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface ICreateRoutineRepository
    {

        string RoutineCode { get; set; }
        string Routine { get; set; }
        int Order { get; set; }

        /// <summary>
        /// Prepares and executes ICreateRoutineRepository.
        /// </summary>
        void Execute();
    }
}