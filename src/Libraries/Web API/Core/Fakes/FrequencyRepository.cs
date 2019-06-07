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
    public class FrequencyRepository : IFrequencyRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Frequency> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Frequency(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Frequency(), 1);
        }

        public MixERP.Net.Entities.Core.Frequency Get(int frequencyId)
        {
            return new MixERP.Net.Entities.Core.Frequency();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Frequency> Get(int[] frequencyIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Frequency(), 1);
        }

        public MixERP.Net.Entities.Core.Frequency GetFirst()
        {
            return new MixERP.Net.Entities.Core.Frequency();
        }

        public MixERP.Net.Entities.Core.Frequency GetPrevious(int frequencyId)
        {
            return new MixERP.Net.Entities.Core.Frequency();
        }

        public MixERP.Net.Entities.Core.Frequency GetNext(int frequencyId)
        {
            return new MixERP.Net.Entities.Core.Frequency();
        }

        public MixERP.Net.Entities.Core.Frequency GetLast()
        {
            return new MixERP.Net.Entities.Core.Frequency();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Frequency> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Frequency(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Frequency> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Frequency(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Frequency> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Frequency(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Frequency> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Frequency(), 1);
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

        public object AddOrEdit(dynamic frequency, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic frequency, int frequencyId)
        {
            if (frequencyId > 0)
            {
                return;
            }

            throw new ArgumentException("frequencyId is null.");
        }

        public object Add(dynamic frequency)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> frequencies)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int frequencyId)
        {
            if (frequencyId > 0)
            {
                return;
            }

            throw new ArgumentException("frequencyId is null.");
        }


    }
}