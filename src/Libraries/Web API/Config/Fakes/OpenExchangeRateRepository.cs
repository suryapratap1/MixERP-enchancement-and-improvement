// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Config.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Config.Fakes
{
    public class OpenExchangeRateRepository : IOpenExchangeRateRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRate(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRate(), 1);
        }

        public MixERP.Net.Entities.Config.OpenExchangeRate Get(string key)
        {
            return new MixERP.Net.Entities.Config.OpenExchangeRate();
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> Get(string[] keys)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRate(), 1);
        }

        public MixERP.Net.Entities.Config.OpenExchangeRate GetFirst()
        {
            return new MixERP.Net.Entities.Config.OpenExchangeRate();
        }

        public MixERP.Net.Entities.Config.OpenExchangeRate GetPrevious(string key)
        {
            return new MixERP.Net.Entities.Config.OpenExchangeRate();
        }

        public MixERP.Net.Entities.Config.OpenExchangeRate GetNext(string key)
        {
            return new MixERP.Net.Entities.Config.OpenExchangeRate();
        }

        public MixERP.Net.Entities.Config.OpenExchangeRate GetLast()
        {
            return new MixERP.Net.Entities.Config.OpenExchangeRate();
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRate(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRate(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRate(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Config.OpenExchangeRate> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.OpenExchangeRate(), 1);
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

        public object AddOrEdit(dynamic openExchangeRate, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic openExchangeRate, string key)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            throw new ArgumentException("key is null.");
        }

        public object Add(dynamic openExchangeRate)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> openExchangeRates)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string key)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            throw new ArgumentException("key is null.");
        }


    }
}