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
    public class CustomFieldDataTypeRepository : ICustomFieldDataTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldDataType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldDataType(), 1);
        }

        public MixERP.Net.Entities.Core.CustomFieldDataType Get(string dataType)
        {
            return new MixERP.Net.Entities.Core.CustomFieldDataType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> Get(string[] dataTypes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldDataType(), 1);
        }

        public MixERP.Net.Entities.Core.CustomFieldDataType GetFirst()
        {
            return new MixERP.Net.Entities.Core.CustomFieldDataType();
        }

        public MixERP.Net.Entities.Core.CustomFieldDataType GetPrevious(string dataType)
        {
            return new MixERP.Net.Entities.Core.CustomFieldDataType();
        }

        public MixERP.Net.Entities.Core.CustomFieldDataType GetNext(string dataType)
        {
            return new MixERP.Net.Entities.Core.CustomFieldDataType();
        }

        public MixERP.Net.Entities.Core.CustomFieldDataType GetLast()
        {
            return new MixERP.Net.Entities.Core.CustomFieldDataType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldDataType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldDataType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldDataType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldDataType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldDataType(), 1);
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

        public object AddOrEdit(dynamic customFieldDataType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic customFieldDataType, string dataType)
        {
            if (!string.IsNullOrWhiteSpace(dataType))
            {
                return;
            }

            throw new ArgumentException("dataType is null.");
        }

        public object Add(dynamic customFieldDataType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> customFieldDataTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string dataType)
        {
            if (!string.IsNullOrWhiteSpace(dataType))
            {
                return;
            }

            throw new ArgumentException("dataType is null.");
        }


    }
}