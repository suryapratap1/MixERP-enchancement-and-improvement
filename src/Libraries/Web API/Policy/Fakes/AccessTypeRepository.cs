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
    public class AccessTypeRepository : IAccessTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.AccessType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.AccessType(), 1);
        }

        public MixERP.Net.Entities.Policy.AccessType Get(int accessTypeId)
        {
            return new MixERP.Net.Entities.Policy.AccessType();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.AccessType> Get(int[] accessTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.AccessType(), 1);
        }

        public MixERP.Net.Entities.Policy.AccessType GetFirst()
        {
            return new MixERP.Net.Entities.Policy.AccessType();
        }

        public MixERP.Net.Entities.Policy.AccessType GetPrevious(int accessTypeId)
        {
            return new MixERP.Net.Entities.Policy.AccessType();
        }

        public MixERP.Net.Entities.Policy.AccessType GetNext(int accessTypeId)
        {
            return new MixERP.Net.Entities.Policy.AccessType();
        }

        public MixERP.Net.Entities.Policy.AccessType GetLast()
        {
            return new MixERP.Net.Entities.Policy.AccessType();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.AccessType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.AccessType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.AccessType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.AccessType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.AccessType(), 1);
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

        public object AddOrEdit(dynamic accessType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic accessType, int accessTypeId)
        {
            if (accessTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("accessTypeId is null.");
        }

        public object Add(dynamic accessType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> accessTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int accessTypeId)
        {
            if (accessTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("accessTypeId is null.");
        }


    }
}