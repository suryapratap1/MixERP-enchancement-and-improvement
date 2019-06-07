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
    public class EmploymentStatusCodeRepository : IEmploymentStatusCodeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatusCode(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatusCode(), 1);
        }

        public MixERP.Net.Entities.HRM.EmploymentStatusCode Get(int employmentStatusCodeId)
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatusCode();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> Get(int[] employmentStatusCodeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatusCode(), 1);
        }

        public MixERP.Net.Entities.HRM.EmploymentStatusCode GetFirst()
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatusCode();
        }

        public MixERP.Net.Entities.HRM.EmploymentStatusCode GetPrevious(int employmentStatusCodeId)
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatusCode();
        }

        public MixERP.Net.Entities.HRM.EmploymentStatusCode GetNext(int employmentStatusCodeId)
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatusCode();
        }

        public MixERP.Net.Entities.HRM.EmploymentStatusCode GetLast()
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatusCode();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatusCode(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatusCode(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatusCode(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatusCode> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatusCode(), 1);
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

        public object AddOrEdit(dynamic employmentStatusCode, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic employmentStatusCode, int employmentStatusCodeId)
        {
            if (employmentStatusCodeId > 0)
            {
                return;
            }

            throw new ArgumentException("employmentStatusCodeId is null.");
        }

        public object Add(dynamic employmentStatusCode)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> employmentStatusCodes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int employmentStatusCodeId)
        {
            if (employmentStatusCodeId > 0)
            {
                return;
            }

            throw new ArgumentException("employmentStatusCodeId is null.");
        }


    }
}