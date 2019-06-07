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
    public class MenuAccessRepository : IMenuAccessRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.MenuAccess(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.MenuAccess(), 1);
        }

        public MixERP.Net.Entities.Policy.MenuAccess Get(long accessId)
        {
            return new MixERP.Net.Entities.Policy.MenuAccess();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> Get(long[] accessIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.MenuAccess(), 1);
        }

        public MixERP.Net.Entities.Policy.MenuAccess GetFirst()
        {
            return new MixERP.Net.Entities.Policy.MenuAccess();
        }

        public MixERP.Net.Entities.Policy.MenuAccess GetPrevious(long accessId)
        {
            return new MixERP.Net.Entities.Policy.MenuAccess();
        }

        public MixERP.Net.Entities.Policy.MenuAccess GetNext(long accessId)
        {
            return new MixERP.Net.Entities.Policy.MenuAccess();
        }

        public MixERP.Net.Entities.Policy.MenuAccess GetLast()
        {
            return new MixERP.Net.Entities.Policy.MenuAccess();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.MenuAccess(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.MenuAccess(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.MenuAccess(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.MenuAccess> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.MenuAccess(), 1);
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

        public object AddOrEdit(dynamic menuAccess, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic menuAccess, long accessId)
        {
            if (accessId > 0)
            {
                return;
            }

            throw new ArgumentException("accessId is null.");
        }

        public object Add(dynamic menuAccess)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> menuAccesses)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long accessId)
        {
            if (accessId > 0)
            {
                return;
            }

            throw new ArgumentException("accessId is null.");
        }


    }
}