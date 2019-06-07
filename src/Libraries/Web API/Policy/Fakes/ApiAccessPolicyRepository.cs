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
    public class ApiAccessPolicyRepository : IApiAccessPolicyRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.ApiAccessPolicy(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.ApiAccessPolicy(), 1);
        }

        public MixERP.Net.Entities.Policy.ApiAccessPolicy Get(long apiAccessPolicyId)
        {
            return new MixERP.Net.Entities.Policy.ApiAccessPolicy();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> Get(long[] apiAccessPolicyIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.ApiAccessPolicy(), 1);
        }

        public MixERP.Net.Entities.Policy.ApiAccessPolicy GetFirst()
        {
            return new MixERP.Net.Entities.Policy.ApiAccessPolicy();
        }

        public MixERP.Net.Entities.Policy.ApiAccessPolicy GetPrevious(long apiAccessPolicyId)
        {
            return new MixERP.Net.Entities.Policy.ApiAccessPolicy();
        }

        public MixERP.Net.Entities.Policy.ApiAccessPolicy GetNext(long apiAccessPolicyId)
        {
            return new MixERP.Net.Entities.Policy.ApiAccessPolicy();
        }

        public MixERP.Net.Entities.Policy.ApiAccessPolicy GetLast()
        {
            return new MixERP.Net.Entities.Policy.ApiAccessPolicy();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.ApiAccessPolicy(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.ApiAccessPolicy(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.ApiAccessPolicy(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.ApiAccessPolicy> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.ApiAccessPolicy(), 1);
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

        public object AddOrEdit(dynamic apiAccessPolicy, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic apiAccessPolicy, long apiAccessPolicyId)
        {
            if (apiAccessPolicyId > 0)
            {
                return;
            }

            throw new ArgumentException("apiAccessPolicyId is null.");
        }

        public object Add(dynamic apiAccessPolicy)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> apiAccessPolicies)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long apiAccessPolicyId)
        {
            if (apiAccessPolicyId > 0)
            {
                return;
            }

            throw new ArgumentException("apiAccessPolicyId is null.");
        }


    }
}