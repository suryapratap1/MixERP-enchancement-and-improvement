// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Localization.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Localization.Fakes
{
    public class ResourceRepository : IResourceRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Resource> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Resource(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Resource(), 1);
        }

        public MixERP.Net.Entities.Localization.Resource Get(int resourceId)
        {
            return new MixERP.Net.Entities.Localization.Resource();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Resource> Get(int[] resourceIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Resource(), 1);
        }

        public MixERP.Net.Entities.Localization.Resource GetFirst()
        {
            return new MixERP.Net.Entities.Localization.Resource();
        }

        public MixERP.Net.Entities.Localization.Resource GetPrevious(int resourceId)
        {
            return new MixERP.Net.Entities.Localization.Resource();
        }

        public MixERP.Net.Entities.Localization.Resource GetNext(int resourceId)
        {
            return new MixERP.Net.Entities.Localization.Resource();
        }

        public MixERP.Net.Entities.Localization.Resource GetLast()
        {
            return new MixERP.Net.Entities.Localization.Resource();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Resource> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Resource(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Resource> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Resource(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Resource> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Resource(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.Resource> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.Resource(), 1);
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

        public object AddOrEdit(dynamic resource, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic resource, int resourceId)
        {
            if (resourceId > 0)
            {
                return;
            }

            throw new ArgumentException("resourceId is null.");
        }

        public object Add(dynamic resource)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> resources)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int resourceId)
        {
            if (resourceId > 0)
            {
                return;
            }

            throw new ArgumentException("resourceId is null.");
        }


    }
}