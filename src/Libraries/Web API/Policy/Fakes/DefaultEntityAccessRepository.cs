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
    public class DefaultEntityAccessRepository : IDefaultEntityAccessRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.DefaultEntityAccess(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.DefaultEntityAccess(), 1);
        }

        public MixERP.Net.Entities.Policy.DefaultEntityAccess Get(int defaultEntityAccessId)
        {
            return new MixERP.Net.Entities.Policy.DefaultEntityAccess();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> Get(int[] defaultEntityAccessIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.DefaultEntityAccess(), 1);
        }

        public MixERP.Net.Entities.Policy.DefaultEntityAccess GetFirst()
        {
            return new MixERP.Net.Entities.Policy.DefaultEntityAccess();
        }

        public MixERP.Net.Entities.Policy.DefaultEntityAccess GetPrevious(int defaultEntityAccessId)
        {
            return new MixERP.Net.Entities.Policy.DefaultEntityAccess();
        }

        public MixERP.Net.Entities.Policy.DefaultEntityAccess GetNext(int defaultEntityAccessId)
        {
            return new MixERP.Net.Entities.Policy.DefaultEntityAccess();
        }

        public MixERP.Net.Entities.Policy.DefaultEntityAccess GetLast()
        {
            return new MixERP.Net.Entities.Policy.DefaultEntityAccess();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.DefaultEntityAccess(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.DefaultEntityAccess(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.DefaultEntityAccess(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.DefaultEntityAccess> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.DefaultEntityAccess(), 1);
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

        public object AddOrEdit(dynamic defaultEntityAccess, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic defaultEntityAccess, int defaultEntityAccessId)
        {
            if (defaultEntityAccessId > 0)
            {
                return;
            }

            throw new ArgumentException("defaultEntityAccessId is null.");
        }

        public object Add(dynamic defaultEntityAccess)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> defaultEntityAccesses)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int defaultEntityAccessId)
        {
            if (defaultEntityAccessId > 0)
            {
                return;
            }

            throw new ArgumentException("defaultEntityAccessId is null.");
        }


    }
}