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
    public class JobTitleRepository : IJobTitleRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.JobTitle(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.JobTitle(), 1);
        }

        public MixERP.Net.Entities.HRM.JobTitle Get(int jobTitleId)
        {
            return new MixERP.Net.Entities.HRM.JobTitle();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.JobTitle> Get(int[] jobTitleIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.JobTitle(), 1);
        }

        public MixERP.Net.Entities.HRM.JobTitle GetFirst()
        {
            return new MixERP.Net.Entities.HRM.JobTitle();
        }

        public MixERP.Net.Entities.HRM.JobTitle GetPrevious(int jobTitleId)
        {
            return new MixERP.Net.Entities.HRM.JobTitle();
        }

        public MixERP.Net.Entities.HRM.JobTitle GetNext(int jobTitleId)
        {
            return new MixERP.Net.Entities.HRM.JobTitle();
        }

        public MixERP.Net.Entities.HRM.JobTitle GetLast()
        {
            return new MixERP.Net.Entities.HRM.JobTitle();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.JobTitle(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.JobTitle(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.JobTitle(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.JobTitle> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.JobTitle(), 1);
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

        public object AddOrEdit(dynamic jobTitle, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic jobTitle, int jobTitleId)
        {
            if (jobTitleId > 0)
            {
                return;
            }

            throw new ArgumentException("jobTitleId is null.");
        }

        public object Add(dynamic jobTitle)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> jobTitles)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int jobTitleId)
        {
            if (jobTitleId > 0)
            {
                return;
            }

            throw new ArgumentException("jobTitleId is null.");
        }


    }
}