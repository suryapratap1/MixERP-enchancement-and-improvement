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
    public class StorePolicyDetailRepository : IStorePolicyDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicyDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicyDetail(), 1);
        }

        public MixERP.Net.Entities.Policy.StorePolicyDetail Get(long storePolicyDetailId)
        {
            return new MixERP.Net.Entities.Policy.StorePolicyDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> Get(long[] storePolicyDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicyDetail(), 1);
        }

        public MixERP.Net.Entities.Policy.StorePolicyDetail GetFirst()
        {
            return new MixERP.Net.Entities.Policy.StorePolicyDetail();
        }

        public MixERP.Net.Entities.Policy.StorePolicyDetail GetPrevious(long storePolicyDetailId)
        {
            return new MixERP.Net.Entities.Policy.StorePolicyDetail();
        }

        public MixERP.Net.Entities.Policy.StorePolicyDetail GetNext(long storePolicyDetailId)
        {
            return new MixERP.Net.Entities.Policy.StorePolicyDetail();
        }

        public MixERP.Net.Entities.Policy.StorePolicyDetail GetLast()
        {
            return new MixERP.Net.Entities.Policy.StorePolicyDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicyDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicyDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicyDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.StorePolicyDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.StorePolicyDetail(), 1);
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

        public object AddOrEdit(dynamic storePolicyDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic storePolicyDetail, long storePolicyDetailId)
        {
            if (storePolicyDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("storePolicyDetailId is null.");
        }

        public object Add(dynamic storePolicyDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> storePolicyDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long storePolicyDetailId)
        {
            if (storePolicyDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("storePolicyDetailId is null.");
        }


    }
}