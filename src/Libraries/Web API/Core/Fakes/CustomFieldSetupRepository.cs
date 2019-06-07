// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Core.Fakes
{
    public class CustomFieldSetupRepository : ICustomFieldSetupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldSetup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldSetup(), 1);
        }

        public MixERP.Net.Entities.Core.CustomFieldSetup Get(int customFieldSetupId)
        {
            return new MixERP.Net.Entities.Core.CustomFieldSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> Get(int[] customFieldSetupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldSetup(), 1);
        }

        public MixERP.Net.Entities.Core.CustomFieldSetup GetFirst()
        {
            return new MixERP.Net.Entities.Core.CustomFieldSetup();
        }

        public MixERP.Net.Entities.Core.CustomFieldSetup GetPrevious(int customFieldSetupId)
        {
            return new MixERP.Net.Entities.Core.CustomFieldSetup();
        }

        public MixERP.Net.Entities.Core.CustomFieldSetup GetNext(int customFieldSetupId)
        {
            return new MixERP.Net.Entities.Core.CustomFieldSetup();
        }

        public MixERP.Net.Entities.Core.CustomFieldSetup GetLast()
        {
            return new MixERP.Net.Entities.Core.CustomFieldSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldSetup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldSetup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldSetup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldSetup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldSetup(), 1);
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

        public object AddOrEdit(dynamic customFieldSetup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic customFieldSetup, int customFieldSetupId)
        {
            if (customFieldSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("customFieldSetupId is null.");
        }

        public object Add(dynamic customFieldSetup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> customFieldSetups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int customFieldSetupId)
        {
            if (customFieldSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("customFieldSetupId is null.");
        }


    }
}