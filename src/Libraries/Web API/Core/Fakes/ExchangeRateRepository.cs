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
    public class ExchangeRateRepository : IExchangeRateRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRate(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRate(), 1);
        }

        public MixERP.Net.Entities.Core.ExchangeRate Get(long exchangeRateId)
        {
            return new MixERP.Net.Entities.Core.ExchangeRate();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> Get(long[] exchangeRateIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRate(), 1);
        }

        public MixERP.Net.Entities.Core.ExchangeRate GetFirst()
        {
            return new MixERP.Net.Entities.Core.ExchangeRate();
        }

        public MixERP.Net.Entities.Core.ExchangeRate GetPrevious(long exchangeRateId)
        {
            return new MixERP.Net.Entities.Core.ExchangeRate();
        }

        public MixERP.Net.Entities.Core.ExchangeRate GetNext(long exchangeRateId)
        {
            return new MixERP.Net.Entities.Core.ExchangeRate();
        }

        public MixERP.Net.Entities.Core.ExchangeRate GetLast()
        {
            return new MixERP.Net.Entities.Core.ExchangeRate();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRate(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRate(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRate(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRate> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRate(), 1);
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

        public object AddOrEdit(dynamic exchangeRate, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic exchangeRate, long exchangeRateId)
        {
            if (exchangeRateId > 0)
            {
                return;
            }

            throw new ArgumentException("exchangeRateId is null.");
        }

        public object Add(dynamic exchangeRate)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> exchangeRates)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long exchangeRateId)
        {
            if (exchangeRateId > 0)
            {
                return;
            }

            throw new ArgumentException("exchangeRateId is null.");
        }


    }
}