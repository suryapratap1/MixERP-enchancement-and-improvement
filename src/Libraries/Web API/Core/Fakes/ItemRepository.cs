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
    public class ItemRepository : IItemRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Item> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Item(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Item(), 1);
        }

        public MixERP.Net.Entities.Core.Item Get(int itemId)
        {
            return new MixERP.Net.Entities.Core.Item();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Item> Get(int[] itemIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Item(), 1);
        }

        public MixERP.Net.Entities.Core.Item GetFirst()
        {
            return new MixERP.Net.Entities.Core.Item();
        }

        public MixERP.Net.Entities.Core.Item GetPrevious(int itemId)
        {
            return new MixERP.Net.Entities.Core.Item();
        }

        public MixERP.Net.Entities.Core.Item GetNext(int itemId)
        {
            return new MixERP.Net.Entities.Core.Item();
        }

        public MixERP.Net.Entities.Core.Item GetLast()
        {
            return new MixERP.Net.Entities.Core.Item();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Item> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Item(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Item> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Item(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Item> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Item(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Item> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Item(), 1);
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

        public object AddOrEdit(dynamic item, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic item, int itemId)
        {
            if (itemId > 0)
            {
                return;
            }

            throw new ArgumentException("itemId is null.");
        }

        public object Add(dynamic item)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> items)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int itemId)
        {
            if (itemId > 0)
            {
                return;
            }

            throw new ArgumentException("itemId is null.");
        }


    }
}