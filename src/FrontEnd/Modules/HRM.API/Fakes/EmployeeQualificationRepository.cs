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
    public class EmployeeQualificationRepository : IEmployeeQualificationRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeQualification(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeQualification(), 1);
        }

        public MixERP.Net.Entities.HRM.EmployeeQualification Get(long employeeQualificationId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeQualification();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> Get(long[] employeeQualificationIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeQualification(), 1);
        }

        public MixERP.Net.Entities.HRM.EmployeeQualification GetFirst()
        {
            return new MixERP.Net.Entities.HRM.EmployeeQualification();
        }

        public MixERP.Net.Entities.HRM.EmployeeQualification GetPrevious(long employeeQualificationId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeQualification();
        }

        public MixERP.Net.Entities.HRM.EmployeeQualification GetNext(long employeeQualificationId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeQualification();
        }

        public MixERP.Net.Entities.HRM.EmployeeQualification GetLast()
        {
            return new MixERP.Net.Entities.HRM.EmployeeQualification();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeQualification(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeQualification(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeQualification(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeQualification> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeQualification(), 1);
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

        public object AddOrEdit(dynamic employeeQualification, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic employeeQualification, long employeeQualificationId)
        {
            if (employeeQualificationId > 0)
            {
                return;
            }

            throw new ArgumentException("employeeQualificationId is null.");
        }

        public object Add(dynamic employeeQualification)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> employeeQualifications)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long employeeQualificationId)
        {
            if (employeeQualificationId > 0)
            {
                return;
            }

            throw new ArgumentException("employeeQualificationId is null.");
        }


    }
}