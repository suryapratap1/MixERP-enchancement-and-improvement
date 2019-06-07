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
    public class EducationLevelRepository : IEducationLevelRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EducationLevel(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EducationLevel(), 1);
        }

        public MixERP.Net.Entities.HRM.EducationLevel Get(int educationLevelId)
        {
            return new MixERP.Net.Entities.HRM.EducationLevel();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> Get(int[] educationLevelIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EducationLevel(), 1);
        }

        public MixERP.Net.Entities.HRM.EducationLevel GetFirst()
        {
            return new MixERP.Net.Entities.HRM.EducationLevel();
        }

        public MixERP.Net.Entities.HRM.EducationLevel GetPrevious(int educationLevelId)
        {
            return new MixERP.Net.Entities.HRM.EducationLevel();
        }

        public MixERP.Net.Entities.HRM.EducationLevel GetNext(int educationLevelId)
        {
            return new MixERP.Net.Entities.HRM.EducationLevel();
        }

        public MixERP.Net.Entities.HRM.EducationLevel GetLast()
        {
            return new MixERP.Net.Entities.HRM.EducationLevel();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EducationLevel(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EducationLevel(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EducationLevel(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.EducationLevel> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.EducationLevel(), 1);
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

        public object AddOrEdit(dynamic educationLevel, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic educationLevel, int educationLevelId)
        {
            if (educationLevelId > 0)
            {
                return;
            }

            throw new ArgumentException("educationLevelId is null.");
        }

        public object Add(dynamic educationLevel)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> educationLevels)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int educationLevelId)
        {
            if (educationLevelId > 0)
            {
                return;
            }

            throw new ArgumentException("educationLevelId is null.");
        }


    }
}