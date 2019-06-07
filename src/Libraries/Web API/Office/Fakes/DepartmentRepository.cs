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
    public class DepartmentRepository : IDepartmentRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Department> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Department(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Department(), 1);
        }

        public MixERP.Net.Entities.Office.Department Get(int departmentId)
        {
            return new MixERP.Net.Entities.Office.Department();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Department> Get(int[] departmentIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Department(), 1);
        }

        public MixERP.Net.Entities.Office.Department GetFirst()
        {
            return new MixERP.Net.Entities.Office.Department();
        }

        public MixERP.Net.Entities.Office.Department GetPrevious(int departmentId)
        {
            return new MixERP.Net.Entities.Office.Department();
        }

        public MixERP.Net.Entities.Office.Department GetNext(int departmentId)
        {
            return new MixERP.Net.Entities.Office.Department();
        }

        public MixERP.Net.Entities.Office.Department GetLast()
        {
            return new MixERP.Net.Entities.Office.Department();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Department> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Department(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.Department> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Department(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Department> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Department(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Department> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Department(), 1);
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

        public object AddOrEdit(dynamic department, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic department, int departmentId)
        {
            if (departmentId > 0)
            {
                return;
            }

            throw new ArgumentException("departmentId is null.");
        }

        public object Add(dynamic department)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> departments)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int departmentId)
        {
            if (departmentId > 0)
            {
                return;
            }

            throw new ArgumentException("departmentId is null.");
        }


    }
}