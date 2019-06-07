// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Core;
namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICreateKanbanRepository
    {

        string ObjectName { get; set; }
        int UserId { get; set; }
        string KanbanName { get; set; }
        string Description { get; set; }

        /// <summary>
        /// Prepares and executes ICreateKanbanRepository.
        /// </summary>
        void Execute();
    }
}