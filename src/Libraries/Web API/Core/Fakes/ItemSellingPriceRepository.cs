// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Core.Fakes
{
    public class ItemSellingPriceRepository : IItemSellingPriceRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemSellingPrice(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemSellingPrice(), 1);
        }

        public MixERP.Net.Entities.Core.ItemSellingPrice Get(long itemSellingPriceId)
        {
            return new MixERP.Net.Entities.Core.ItemSellingPrice();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> Get(long[] itemSellingPriceIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemSellingPrice(), 1);
        }

        public MixERP.Net.Entities.Core.ItemSellingPrice GetFirst()
        {
            return new MixERP.Net.Entities.Core.ItemSellingPrice();
        }

        public MixERP.Net.Entities.Core.ItemSellingPrice GetPrevious(long itemSellingPriceId)
        {
            return new MixERP.Net.Entities.Core.ItemSellingPrice();
        }

        public MixERP.Net.Entities.Core.ItemSellingPrice GetNext(long itemSellingPriceId)
        {
            return new MixERP.Net.Entities.Core.ItemSellingPrice();
        }

        public MixERP.Net.Entities.Core.ItemSellingPrice GetLast()
        {
            return new MixERP.Net.Entities.Core.ItemSellingPrice();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemSellingPrice(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemSellingPrice(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemSellingPrice(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemSellingPrice(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public object AddOrEdit(dynamic itemSellingPrice, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic itemSellingPrice, long itemSellingPriceId)
        {
            if (itemSellingPriceId > 0)
            {
                return;
            }

            throw new ArgumentException("itemSellingPriceId is null.");
        }

        public object Add(dynamic itemSellingPrice)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> itemSellingPrices)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long itemSellingPriceId)
        {
            if (itemSellingPriceId > 0)
            {
                return;
            }

            throw new ArgumentException("itemSellingPriceId is null.");
        }


    }
}