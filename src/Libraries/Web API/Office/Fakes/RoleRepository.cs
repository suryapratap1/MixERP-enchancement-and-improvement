// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Office.Fakes
{
    public class RoleRepository : IRoleRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Role> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Role(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Role(), 1);
        }

        public MixERP.Net.Entities.Office.Role Get(int roleId)
        {
            return new MixERP.Net.Entities.Office.Role();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Role> Get(int[] roleIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Role(), 1);
        }

        public MixERP.Net.Entities.Office.Role GetFirst()
        {
            return new MixERP.Net.Entities.Office.Role();
        }

        public MixERP.Net.Entities.Office.Role GetPrevious(int roleId)
        {
            return new MixERP.Net.Entities.Office.Role();
        }

        public MixERP.Net.Entities.Office.Role GetNext(int roleId)
        {
            return new MixERP.Net.Entities.Office.Role();
        }

        public MixERP.Net.Entities.Office.Role GetLast()
        {
            return new MixERP.Net.Entities.Office.Role();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Role> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Role(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.Role> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Role(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Role> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Role(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Role> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Role(), 1);
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

        public object AddOrEdit(dynamic role, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic role, int roleId)
        {
            if (roleId > 0)
            {
                return;
            }

            throw new ArgumentException("roleId is null.");
        }

        public object Add(dynamic role)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> roles)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int roleId)
        {
            if (roleId > 0)
            {
                return;
            }

            throw new ArgumentException("roleId is null.");
        }


    }
}