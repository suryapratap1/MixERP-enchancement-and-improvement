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
    public class CustomFieldRepository : ICustomFieldRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomField> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomField(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomField(), 1);
        }

        public MixERP.Net.Entities.Core.CustomField Get(long customFieldId)
        {
            return new MixERP.Net.Entities.Core.CustomField();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomField> Get(long[] customFieldIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomField(), 1);
        }

        public MixERP.Net.Entities.Core.CustomField GetFirst()
        {
            return new MixERP.Net.Entities.Core.CustomField();
        }

        public MixERP.Net.Entities.Core.CustomField GetPrevious(long customFieldId)
        {
            return new MixERP.Net.Entities.Core.CustomField();
        }

        public MixERP.Net.Entities.Core.CustomField GetNext(long customFieldId)
        {
            return new MixERP.Net.Entities.Core.CustomField();
        }

        public MixERP.Net.Entities.Core.CustomField GetLast()
        {
            return new MixERP.Net.Entities.Core.CustomField();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomField> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomField(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomField> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomField(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomField> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomField(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomField> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomField(), 1);
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

        public object AddOrEdit(dynamic customField, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic customField, long customFieldId)
        {
            if (customFieldId > 0)
            {
                return;
            }

            throw new ArgumentException("customFieldId is null.");
        }

        public object Add(dynamic customField)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> customFields)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long customFieldId)
        {
            if (customFieldId > 0)
            {
                return;
            }

            throw new ArgumentException("customFieldId is null.");
        }


    }
}