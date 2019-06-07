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
    public class CompoundItemRepository : ICompoundItemRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItem(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItem(), 1);
        }

        public MixERP.Net.Entities.Core.CompoundItem Get(int compoundItemId)
        {
            return new MixERP.Net.Entities.Core.CompoundItem();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> Get(int[] compoundItemIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItem(), 1);
        }

        public MixERP.Net.Entities.Core.CompoundItem GetFirst()
        {
            return new MixERP.Net.Entities.Core.CompoundItem();
        }

        public MixERP.Net.Entities.Core.CompoundItem GetPrevious(int compoundItemId)
        {
            return new MixERP.Net.Entities.Core.CompoundItem();
        }

        public MixERP.Net.Entities.Core.CompoundItem GetNext(int compoundItemId)
        {
            return new MixERP.Net.Entities.Core.CompoundItem();
        }

        public MixERP.Net.Entities.Core.CompoundItem GetLast()
        {
            return new MixERP.Net.Entities.Core.CompoundItem();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItem(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItem(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItem(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItem> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItem(), 1);
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

        public object AddOrEdit(dynamic compoundItem, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic compoundItem, int compoundItemId)
        {
            if (compoundItemId > 0)
            {
                return;
            }

            throw new ArgumentException("compoundItemId is null.");
        }

        public object Add(dynamic compoundItem)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> compoundItems)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int compoundItemId)
        {
            if (compoundItemId > 0)
            {
                return;
            }

            throw new ArgumentException("compoundItemId is null.");
        }


    }
}