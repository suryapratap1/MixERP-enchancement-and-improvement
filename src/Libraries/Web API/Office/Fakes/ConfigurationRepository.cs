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
    public class ConfigurationRepository : IConfigurationRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Configuration(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Configuration(), 1);
        }

        public MixERP.Net.Entities.Office.Configuration Get(int configurationId)
        {
            return new MixERP.Net.Entities.Office.Configuration();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Configuration> Get(int[] configurationIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Configuration(), 1);
        }

        public MixERP.Net.Entities.Office.Configuration GetFirst()
        {
            return new MixERP.Net.Entities.Office.Configuration();
        }

        public MixERP.Net.Entities.Office.Configuration GetPrevious(int configurationId)
        {
            return new MixERP.Net.Entities.Office.Configuration();
        }

        public MixERP.Net.Entities.Office.Configuration GetNext(int configurationId)
        {
            return new MixERP.Net.Entities.Office.Configuration();
        }

        public MixERP.Net.Entities.Office.Configuration GetLast()
        {
            return new MixERP.Net.Entities.Office.Configuration();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Configuration(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Configuration(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Configuration(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Configuration> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Configuration(), 1);
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

        public object AddOrEdit(dynamic configuration, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic configuration, int configurationId)
        {
            if (configurationId > 0)
            {
                return;
            }

            throw new ArgumentException("configurationId is null.");
        }

        public object Add(dynamic configuration)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> configurations)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int configurationId)
        {
            if (configurationId > 0)
            {
                return;
            }

            throw new ArgumentException("configurationId is null.");
        }


    }
}