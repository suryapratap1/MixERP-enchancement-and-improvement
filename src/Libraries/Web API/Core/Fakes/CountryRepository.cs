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
    public class CountryRepository : ICountryRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Country> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Country(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Country(), 1);
        }

        public MixERP.Net.Entities.Core.Country Get(int countryId)
        {
            return new MixERP.Net.Entities.Core.Country();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Country> Get(int[] countryIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Country(), 1);
        }

        public MixERP.Net.Entities.Core.Country GetFirst()
        {
            return new MixERP.Net.Entities.Core.Country();
        }

        public MixERP.Net.Entities.Core.Country GetPrevious(int countryId)
        {
            return new MixERP.Net.Entities.Core.Country();
        }

        public MixERP.Net.Entities.Core.Country GetNext(int countryId)
        {
            return new MixERP.Net.Entities.Core.Country();
        }

        public MixERP.Net.Entities.Core.Country GetLast()
        {
            return new MixERP.Net.Entities.Core.Country();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Country> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Country(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Country> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Country(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Country> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Country(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Country> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Country(), 1);
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

        public object AddOrEdit(dynamic country, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic country, int countryId)
        {
            if (countryId > 0)
            {
                return;
            }

            throw new ArgumentException("countryId is null.");
        }

        public object Add(dynamic country)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> countries)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int countryId)
        {
            if (countryId > 0)
            {
                return;
            }

            throw new ArgumentException("countryId is null.");
        }


    }
}