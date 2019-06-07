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
    public class FilterRepository : IFilterRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Filter> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Filter(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Filter(), 1);
        }

        public MixERP.Net.Entities.Core.Filter Get(long filterId)
        {
            return new MixERP.Net.Entities.Core.Filter();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Filter> Get(long[] filterIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Filter(), 1);
        }

        public MixERP.Net.Entities.Core.Filter GetFirst()
        {
            return new MixERP.Net.Entities.Core.Filter();
        }

        public MixERP.Net.Entities.Core.Filter GetPrevious(long filterId)
        {
            return new MixERP.Net.Entities.Core.Filter();
        }

        public MixERP.Net.Entities.Core.Filter GetNext(long filterId)
        {
            return new MixERP.Net.Entities.Core.Filter();
        }

        public MixERP.Net.Entities.Core.Filter GetLast()
        {
            return new MixERP.Net.Entities.Core.Filter();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Filter> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Filter(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Filter> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Filter(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Filter> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Filter(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Filter> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Filter(), 1);
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

        public object AddOrEdit(dynamic filter, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic filter, long filterId)
        {
            if (filterId > 0)
            {
                return;
            }

            throw new ArgumentException("filterId is null.");
        }

        public object Add(dynamic filter)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> filters)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long filterId)
        {
            if (filterId > 0)
            {
                return;
            }

            throw new ArgumentException("filterId is null.");
        }

        public void Delete(string filterName)
        {
            if (string.IsNullOrWhiteSpace(filterName))
            {
                throw new ArgumentException("filterName is null.");
            }
        }

        public void RecreateFilters(string objectName, string filterName, List<MixERP.Net.Entities.Core.Filter> filters)
        {
            if (string.IsNullOrWhiteSpace(objectName))
            {
                throw new ArgumentException("objectName is null.");
            }

            if (string.IsNullOrWhiteSpace(filterName))
            {
                throw new ArgumentException("filterName is null.");
            }
        }

        public void MakeDefault(string objectName, string filterName)
        {
            if (string.IsNullOrWhiteSpace(objectName))
            {
                throw new ArgumentException("objectName is null.");
            }

            if (string.IsNullOrWhiteSpace(filterName))
            {
                throw new ArgumentException("filterName is null.");
            }
        }

        public void RemoveDefault(string objectName)
        {
            if (string.IsNullOrWhiteSpace(objectName))
            {
                throw new ArgumentException("objectName is null.");
            }
        }

    }
}