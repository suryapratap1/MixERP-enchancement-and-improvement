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
    public class EmploymentStatusRepository : IEmploymentStatusRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatus(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatus(), 1);
        }

        public MixERP.Net.Entities.HRM.EmploymentStatus Get(int employmentStatusId)
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatus();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> Get(int[] employmentStatusIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatus(), 1);
        }

        public MixERP.Net.Entities.HRM.EmploymentStatus GetFirst()
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatus();
        }

        public MixERP.Net.Entities.HRM.EmploymentStatus GetPrevious(int employmentStatusId)
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatus();
        }

        public MixERP.Net.Entities.HRM.EmploymentStatus GetNext(int employmentStatusId)
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatus();
        }

        public MixERP.Net.Entities.HRM.EmploymentStatus GetLast()
        {
            return new MixERP.Net.Entities.HRM.EmploymentStatus();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatus(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatus(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatus(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EmploymentStatus> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EmploymentStatus(), 1);
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

        public object AddOrEdit(dynamic employmentStatus, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic employmentStatus, int employmentStatusId)
        {
            if (employmentStatusId > 0)
            {
                return;
            }

            throw new ArgumentException("employmentStatusId is null.");
        }

        public object Add(dynamic employmentStatus)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> employmentStatuses)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int employmentStatusId)
        {
            if (employmentStatusId > 0)
            {
                return;
            }

            throw new ArgumentException("employmentStatusId is null.");
        }


    }
}