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
    public class IndustryRepository : IIndustryRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Industry> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Industry(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Industry(), 1);
        }

        public MixERP.Net.Entities.Core.Industry Get(int industryId)
        {
            return new MixERP.Net.Entities.Core.Industry();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Industry> Get(int[] industryIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Industry(), 1);
        }

        public MixERP.Net.Entities.Core.Industry GetFirst()
        {
            return new MixERP.Net.Entities.Core.Industry();
        }

        public MixERP.Net.Entities.Core.Industry GetPrevious(int industryId)
        {
            return new MixERP.Net.Entities.Core.Industry();
        }

        public MixERP.Net.Entities.Core.Industry GetNext(int industryId)
        {
            return new MixERP.Net.Entities.Core.Industry();
        }

        public MixERP.Net.Entities.Core.Industry GetLast()
        {
            return new MixERP.Net.Entities.Core.Industry();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Industry> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Industry(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Industry> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Industry(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Industry> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Industry(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Industry> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Industry(), 1);
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

        public object AddOrEdit(dynamic industry, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic industry, int industryId)
        {
            if (industryId > 0)
            {
                return;
            }

            throw new ArgumentException("industryId is null.");
        }

        public object Add(dynamic industry)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> industries)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int industryId)
        {
            if (industryId > 0)
            {
                return;
            }

            throw new ArgumentException("industryId is null.");
        }


    }
}