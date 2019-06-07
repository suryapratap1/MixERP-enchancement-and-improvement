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
    public class CurrencyRepository : ICurrencyRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Currency> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Currency(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Currency(), 1);
        }

        public MixERP.Net.Entities.Core.Currency Get(string currencyCode)
        {
            return new MixERP.Net.Entities.Core.Currency();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Currency> Get(string[] currencyCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Currency(), 1);
        }

        public MixERP.Net.Entities.Core.Currency GetFirst()
        {
            return new MixERP.Net.Entities.Core.Currency();
        }

        public MixERP.Net.Entities.Core.Currency GetPrevious(string currencyCode)
        {
            return new MixERP.Net.Entities.Core.Currency();
        }

        public MixERP.Net.Entities.Core.Currency GetNext(string currencyCode)
        {
            return new MixERP.Net.Entities.Core.Currency();
        }

        public MixERP.Net.Entities.Core.Currency GetLast()
        {
            return new MixERP.Net.Entities.Core.Currency();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Currency> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Currency(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Currency> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Currency(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Currency> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Currency(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Currency> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Currency(), 1);
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

        public object AddOrEdit(dynamic currency, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic currency, string currencyCode)
        {
            if (!string.IsNullOrWhiteSpace(currencyCode))
            {
                return;
            }

            throw new ArgumentException("currencyCode is null.");
        }

        public object Add(dynamic currency)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> currencies)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string currencyCode)
        {
            if (!string.IsNullOrWhiteSpace(currencyCode))
            {
                return;
            }

            throw new ArgumentException("currencyCode is null.");
        }


    }
}