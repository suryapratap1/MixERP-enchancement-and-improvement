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
    public class ExchangeRateDetailRepository : IExchangeRateDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRateDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRateDetail(), 1);
        }

        public MixERP.Net.Entities.Core.ExchangeRateDetail Get(long exchangeRateDetailId)
        {
            return new MixERP.Net.Entities.Core.ExchangeRateDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> Get(long[] exchangeRateDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRateDetail(), 1);
        }

        public MixERP.Net.Entities.Core.ExchangeRateDetail GetFirst()
        {
            return new MixERP.Net.Entities.Core.ExchangeRateDetail();
        }

        public MixERP.Net.Entities.Core.ExchangeRateDetail GetPrevious(long exchangeRateDetailId)
        {
            return new MixERP.Net.Entities.Core.ExchangeRateDetail();
        }

        public MixERP.Net.Entities.Core.ExchangeRateDetail GetNext(long exchangeRateDetailId)
        {
            return new MixERP.Net.Entities.Core.ExchangeRateDetail();
        }

        public MixERP.Net.Entities.Core.ExchangeRateDetail GetLast()
        {
            return new MixERP.Net.Entities.Core.ExchangeRateDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRateDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRateDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRateDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ExchangeRateDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ExchangeRateDetail(), 1);
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

        public object AddOrEdit(dynamic exchangeRateDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic exchangeRateDetail, long exchangeRateDetailId)
        {
            if (exchangeRateDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("exchangeRateDetailId is null.");
        }

        public object Add(dynamic exchangeRateDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> exchangeRateDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long exchangeRateDetailId)
        {
            if (exchangeRateDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("exchangeRateDetailId is null.");
        }


    }
}