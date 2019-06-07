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
    public class EmployeeIdentificationDetailRepository : IEmployeeIdentificationDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail(), 1);
        }

        public MixERP.Net.Entities.HRM.EmployeeIdentificationDetail Get(long employeeIdentificationDetailId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> Get(long[] employeeIdentificationDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail(), 1);
        }

        public MixERP.Net.Entities.HRM.EmployeeIdentificationDetail GetFirst()
        {
            return new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail();
        }

        public MixERP.Net.Entities.HRM.EmployeeIdentificationDetail GetPrevious(long employeeIdentificationDetailId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail();
        }

        public MixERP.Net.Entities.HRM.EmployeeIdentificationDetail GetNext(long employeeIdentificationDetailId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail();
        }

        public MixERP.Net.Entities.HRM.EmployeeIdentificationDetail GetLast()
        {
            return new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeIdentificationDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeIdentificationDetail(), 1);
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

        public object AddOrEdit(dynamic employeeIdentificationDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic employeeIdentificationDetail, long employeeIdentificationDetailId)
        {
            if (employeeIdentificationDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("employeeIdentificationDetailId is null.");
        }

        public object Add(dynamic employeeIdentificationDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> employeeIdentificationDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long employeeIdentificationDetailId)
        {
            if (employeeIdentificationDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("employeeIdentificationDetailId is null.");
        }


    }
}