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
    public class AttributeRepository : IAttributeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attribute> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attribute(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attribute(), 1);
        }

        public MixERP.Net.Entities.Core.Attribute Get(int attributeId)
        {
            return new MixERP.Net.Entities.Core.Attribute();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attribute> Get(int[] attributeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attribute(), 1);
        }

        public MixERP.Net.Entities.Core.Attribute GetFirst()
        {
            return new MixERP.Net.Entities.Core.Attribute();
        }

        public MixERP.Net.Entities.Core.Attribute GetPrevious(int attributeId)
        {
            return new MixERP.Net.Entities.Core.Attribute();
        }

        public MixERP.Net.Entities.Core.Attribute GetNext(int attributeId)
        {
            return new MixERP.Net.Entities.Core.Attribute();
        }

        public MixERP.Net.Entities.Core.Attribute GetLast()
        {
            return new MixERP.Net.Entities.Core.Attribute();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attribute> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attribute(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attribute> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attribute(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attribute> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attribute(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Attribute> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Attribute(), 1);
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

        public object AddOrEdit(dynamic attribute, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic attribute, int attributeId)
        {
            if (attributeId > 0)
            {
                return;
            }

            throw new ArgumentException("attributeId is null.");
        }

        public object Add(dynamic attribute)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> attributes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int attributeId)
        {
            if (attributeId > 0)
            {
                return;
            }

            throw new ArgumentException("attributeId is null.");
        }


    }
}