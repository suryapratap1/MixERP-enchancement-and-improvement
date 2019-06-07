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
    public class ItemTypeRepository : IItemTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemType(), 1);
        }

        public MixERP.Net.Entities.Core.ItemType Get(int itemTypeId)
        {
            return new MixERP.Net.Entities.Core.ItemType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemType> Get(int[] itemTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemType(), 1);
        }

        public MixERP.Net.Entities.Core.ItemType GetFirst()
        {
            return new MixERP.Net.Entities.Core.ItemType();
        }

        public MixERP.Net.Entities.Core.ItemType GetPrevious(int itemTypeId)
        {
            return new MixERP.Net.Entities.Core.ItemType();
        }

        public MixERP.Net.Entities.Core.ItemType GetNext(int itemTypeId)
        {
            return new MixERP.Net.Entities.Core.ItemType();
        }

        public MixERP.Net.Entities.Core.ItemType GetLast()
        {
            return new MixERP.Net.Entities.Core.ItemType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemType(), 1);
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

        public object AddOrEdit(dynamic itemType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic itemType, int itemTypeId)
        {
            if (itemTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("itemTypeId is null.");
        }

        public object Add(dynamic itemType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> itemTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int itemTypeId)
        {
            if (itemTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("itemTypeId is null.");
        }


    }
}