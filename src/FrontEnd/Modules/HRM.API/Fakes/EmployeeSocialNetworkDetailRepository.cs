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
    public class EmployeeSocialNetworkDetailRepository : IEmployeeSocialNetworkDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail(), 1);
        }

        public MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail Get(long employeeSocialNetworkDetailId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> Get(long[] employeeSocialNetworkDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail(), 1);
        }

        public MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail GetFirst()
        {
            return new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail();
        }

        public MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail GetPrevious(long employeeSocialNetworkDetailId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail();
        }

        public MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail GetNext(long employeeSocialNetworkDetailId)
        {
            return new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail();
        }

        public MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail GetLast()
        {
            return new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmployeeSocialNetworkDetail(), 1);
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

        public object AddOrEdit(dynamic employeeSocialNetworkDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic employeeSocialNetworkDetail, long employeeSocialNetworkDetailId)
        {
            if (employeeSocialNetworkDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("employeeSocialNetworkDetailId is null.");
        }

        public object Add(dynamic employeeSocialNetworkDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> employeeSocialNetworkDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long employeeSocialNetworkDetailId)
        {
            if (employeeSocialNetworkDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("employeeSocialNetworkDetailId is null.");
        }


    }
}