// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class StorePolicyRepository : IStorePolicyRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicy(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicy(), 1);
        }

        public MixERP.Net.Entities.Policy.StorePolicy Get(long storePolicyId)
        {
            return new MixERP.Net.Entities.Policy.StorePolicy();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> Get(long[] storePolicyIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicy(), 1);
        }

        public MixERP.Net.Entities.Policy.StorePolicy GetFirst()
        {
            return new MixERP.Net.Entities.Policy.StorePolicy();
        }

        public MixERP.Net.Entities.Policy.StorePolicy GetPrevious(long storePolicyId)
        {
            return new MixERP.Net.Entities.Policy.StorePolicy();
        }

        public MixERP.Net.Entities.Policy.StorePolicy GetNext(long storePolicyId)
        {
            return new MixERP.Net.Entities.Policy.StorePolicy();
        }

        public MixERP.Net.Entities.Policy.StorePolicy GetLast()
        {
            return new MixERP.Net.Entities.Policy.StorePolicy();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicy(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicy(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicy(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicy> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicy(), 1);
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

        public object AddOrEdit(dynamic storePolicy, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic storePolicy, long storePolicyId)
        {
            if (storePolicyId > 0)
            {
                return;
            }

            throw new ArgumentException("storePolicyId is null.");
        }

        public object Add(dynamic storePolicy)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> storePolicies)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long storePolicyId)
        {
            if (storePolicyId > 0)
            {
                return;
            }

            throw new ArgumentException("storePolicyId is null.");
        }


    }
}