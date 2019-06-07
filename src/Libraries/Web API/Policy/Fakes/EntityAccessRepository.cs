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
    public class EntityAccessRepository : IEntityAccessRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.EntityAccess(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.EntityAccess(), 1);
        }

        public MixERP.Net.Entities.Policy.EntityAccess Get(int entityAccessId)
        {
            return new MixERP.Net.Entities.Policy.EntityAccess();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> Get(int[] entityAccessIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.EntityAccess(), 1);
        }

        public MixERP.Net.Entities.Policy.EntityAccess GetFirst()
        {
            return new MixERP.Net.Entities.Policy.EntityAccess();
        }

        public MixERP.Net.Entities.Policy.EntityAccess GetPrevious(int entityAccessId)
        {
            return new MixERP.Net.Entities.Policy.EntityAccess();
        }

        public MixERP.Net.Entities.Policy.EntityAccess GetNext(int entityAccessId)
        {
            return new MixERP.Net.Entities.Policy.EntityAccess();
        }

        public MixERP.Net.Entities.Policy.EntityAccess GetLast()
        {
            return new MixERP.Net.Entities.Policy.EntityAccess();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.EntityAccess(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.EntityAccess(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.EntityAccess(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.EntityAccess> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.EntityAccess(), 1);
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

        public object AddOrEdit(dynamic entityAccess, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic entityAccess, int entityAccessId)
        {
            if (entityAccessId > 0)
            {
                return;
            }

            throw new ArgumentException("entityAccessId is null.");
        }

        public object Add(dynamic entityAccess)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> entityAccesses)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int entityAccessId)
        {
            if (entityAccessId > 0)
            {
                return;
            }

            throw new ArgumentException("entityAccessId is null.");
        }


    }
}