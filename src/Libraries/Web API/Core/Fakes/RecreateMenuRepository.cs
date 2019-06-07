// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class RecreateMenuRepository : IRecreateMenuRepository
    {
        public string MenuText { get; set; }
        public string Url { get; set; }
        public string MenuCode { get; set; }
        public int Level { get; set; }
        public int ParentMenuId { get; set; }

        public void Execute()
        {
            return;
        }
    }
}