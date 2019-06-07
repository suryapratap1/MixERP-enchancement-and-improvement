// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Localization.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Localization.Fakes
{
    public class CultureRepository : ICultureRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Culture> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Culture(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Culture(), 1);
        }

        public MixERP.Net.Entities.Localization.Culture Get(string cultureCode)
        {
            return new MixERP.Net.Entities.Localization.Culture();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Culture> Get(string[] cultureCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Culture(), 1);
        }

        public MixERP.Net.Entities.Localization.Culture GetFirst()
        {
            return new MixERP.Net.Entities.Localization.Culture();
        }

        public MixERP.Net.Entities.Localization.Culture GetPrevious(string cultureCode)
        {
            return new MixERP.Net.Entities.Localization.Culture();
        }

        public MixERP.Net.Entities.Localization.Culture GetNext(string cultureCode)
        {
            return new MixERP.Net.Entities.Localization.Culture();
        }

        public MixERP.Net.Entities.Localization.Culture GetLast()
        {
            return new MixERP.Net.Entities.Localization.Culture();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Culture> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Culture(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Culture> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Culture(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Culture> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Culture(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Culture> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Culture(), 1);
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

        public object AddOrEdit(dynamic culture, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic culture, string cultureCode)
        {
            if (!string.IsNullOrWhiteSpace(cultureCode))
            {
                return;
            }

            throw new ArgumentException("cultureCode is null.");
        }

        public object Add(dynamic culture)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> cultures)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string cultureCode)
        {
            if (!string.IsNullOrWhiteSpace(cultureCode))
            {
                return;
            }

            throw new ArgumentException("cultureCode is null.");
        }


    }
}