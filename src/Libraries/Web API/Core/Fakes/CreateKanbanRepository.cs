// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CreateKanbanRepository : ICreateKanbanRepository
    {
        public string ObjectName { get; set; }
        public int UserId { get; set; }
        public string KanbanName { get; set; }
        public string Description { get; set; }

        public void Execute()
        {
            return;
        }
    }
}