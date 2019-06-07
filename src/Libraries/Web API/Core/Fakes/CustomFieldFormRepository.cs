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
    public class CustomFieldFormRepository : ICustomFieldFormRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldForm(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldForm(), 1);
        }

        public MixERP.Net.Entities.Core.CustomFieldForm Get(string formName)
        {
            return new MixERP.Net.Entities.Core.CustomFieldForm();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> Get(string[] formNames)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldForm(), 1);
        }

        public MixERP.Net.Entities.Core.CustomFieldForm GetFirst()
        {
            return new MixERP.Net.Entities.Core.CustomFieldForm();
        }

        public MixERP.Net.Entities.Core.CustomFieldForm GetPrevious(string formName)
        {
            return new MixERP.Net.Entities.Core.CustomFieldForm();
        }

        public MixERP.Net.Entities.Core.CustomFieldForm GetNext(string formName)
        {
            return new MixERP.Net.Entities.Core.CustomFieldForm();
        }

        public MixERP.Net.Entities.Core.CustomFieldForm GetLast()
        {
            return new MixERP.Net.Entities.Core.CustomFieldForm();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldForm(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldForm(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldForm(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CustomFieldForm> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CustomFieldForm(), 1);
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

        public object AddOrEdit(dynamic customFieldForm, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic customFieldForm, string formName)
        {
            if (!string.IsNullOrWhiteSpace(formName))
            {
                return;
            }

            throw new ArgumentException("formName is null.");
        }

        public object Add(dynamic customFieldForm)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> customFieldForms)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string formName)
        {
            if (!string.IsNullOrWhiteSpace(formName))
            {
                return;
            }

            throw new ArgumentException("formName is null.");
        }


    }
}