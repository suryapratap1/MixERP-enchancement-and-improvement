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
    public class VoucherVerificationPolicyRepository : IVoucherVerificationPolicyRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), 1);
        }

        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy Get(int policyId)
        {
            return new MixERP.Net.Entities.Policy.VoucherVerificationPolicy();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> Get(int[] policyIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), 1);
        }

        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetFirst()
        {
            return new MixERP.Net.Entities.Policy.VoucherVerificationPolicy();
        }

        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetPrevious(int policyId)
        {
            return new MixERP.Net.Entities.Policy.VoucherVerificationPolicy();
        }

        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetNext(int policyId)
        {
            return new MixERP.Net.Entities.Policy.VoucherVerificationPolicy();
        }

        public MixERP.Net.Entities.Policy.VoucherVerificationPolicy GetLast()
        {
            return new MixERP.Net.Entities.Policy.VoucherVerificationPolicy();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.VoucherVerificationPolicy> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.VoucherVerificationPolicy(), 1);
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

        public object AddOrEdit(dynamic voucherVerificationPolicy, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic voucherVerificationPolicy, int policyId)
        {
            if (policyId > 0)
            {
                return;
            }

            throw new ArgumentException("policyId is null.");
        }

        public object Add(dynamic voucherVerificationPolicy)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> voucherVerificationPolicies)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int policyId)
        {
            if (policyId > 0)
            {
                return;
            }

            throw new ArgumentException("policyId is null.");
        }


    }
}