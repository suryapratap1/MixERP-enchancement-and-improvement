// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Core.Modules.HRM.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.HRM.Fakes
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeType(), 1);
        }

        public MixERP.Net.Entities.HRM.EmployeeType Get(int employeeTypeId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeType();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> Get(int[] employeeTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeType(), 1);
        }

        public MixERP.Net.Entities.HRM.EmployeeType GetFirst()
        {
            return new MixERP.Net.Entities.HRM.EmployeeType();
        }

        public MixERP.Net.Entities.HRM.EmployeeType GetPrevious(int employeeTypeId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeType();
        }

        public MixERP.Net.Entities.HRM.EmployeeType GetNext(int employeeTypeId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeType();
        }

        public MixERP.Net.Entities.HRM.EmployeeType GetLast()
        {
            return new MixERP.Net.Entities.HRM.EmployeeType();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeType(), 1);
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

        public object AddOrEdit(dynamic employeeType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic employeeType, int employeeTypeId)
        {
            if (employeeTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("employeeTypeId is null.");
        }

        public object Add(dynamic employeeType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> employeeTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int employeeTypeId)
        {
            if (employeeTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("employeeTypeId is null.");
        }


    }
}