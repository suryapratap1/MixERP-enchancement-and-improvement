// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CreateItemVariantRepository : ICreateItemVariantRepository
    {
        public int VariantOf { get; set; }
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int[] VariantIds { get; set; }
        public int UserId { get; set; }

        public int Execute()
        {
            return 1;
        }
    }
}