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
    public class ItemGroupRepository : IItemGroupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroup(), 1);
        }

        public MixERP.Net.Entities.Core.ItemGroup Get(int itemGroupId)
        {
            return new MixERP.Net.Entities.Core.ItemGroup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> Get(int[] itemGroupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroup(), 1);
        }

        public MixERP.Net.Entities.Core.ItemGroup GetFirst()
        {
            return new MixERP.Net.Entities.Core.ItemGroup();
        }

        public MixERP.Net.Entities.Core.ItemGroup GetPrevious(int itemGroupId)
        {
            return new MixERP.Net.Entities.Core.ItemGroup();
        }

        public MixERP.Net.Entities.Core.ItemGroup GetNext(int itemGroupId)
        {
            return new MixERP.Net.Entities.Core.ItemGroup();
        }

        public MixERP.Net.Entities.Core.ItemGroup GetLast()
        {
            return new MixERP.Net.Entities.Core.ItemGroup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ItemGroup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ItemGroup(), 1);
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

        public object AddOrEdit(dynamic itemGroup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic itemGroup, int itemGroupId)
        {
            if (itemGroupId > 0)
            {
                return;
            }

            throw new ArgumentException("itemGroupId is null.");
        }

        public object Add(dynamic itemGroup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> itemGroups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int itemGroupId)
        {
            if (itemGroupId > 0)
            {
                return;
            }

            throw new ArgumentException("itemGroupId is null.");
        }


    }
}