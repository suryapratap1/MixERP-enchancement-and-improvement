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
    public class LocalizedResourceRepository : ILocalizedResourceRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.LocalizedResource(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.LocalizedResource(), 1);
        }

        public MixERP.Net.Entities.Localization.LocalizedResource Get(long localizedResourceId)
        {
            return new MixERP.Net.Entities.Localization.LocalizedResource();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> Get(long[] localizedResourceIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.LocalizedResource(), 1);
        }

        public MixERP.Net.Entities.Localization.LocalizedResource GetFirst()
        {
            return new MixERP.Net.Entities.Localization.LocalizedResource();
        }

        public MixERP.Net.Entities.Localization.LocalizedResource GetPrevious(long localizedResourceId)
        {
            return new MixERP.Net.Entities.Localization.LocalizedResource();
        }

        public MixERP.Net.Entities.Localization.LocalizedResource GetNext(long localizedResourceId)
        {
            return new MixERP.Net.Entities.Localization.LocalizedResource();
        }

        public MixERP.Net.Entities.Localization.LocalizedResource GetLast()
        {
            return new MixERP.Net.Entities.Localization.LocalizedResource();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.LocalizedResource(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.LocalizedResource(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.LocalizedResource(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Localization.LocalizedResource> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Localization.LocalizedResource(), 1);
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

        public object AddOrEdit(dynamic localizedResource, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic localizedResource, long localizedResourceId)
        {
            if (localizedResourceId > 0)
            {
                return;
            }

            throw new ArgumentException("localizedResourceId is null.");
        }

        public object Add(dynamic localizedResource)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> localizedResources)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long localizedResourceId)
        {
            if (localizedResourceId > 0)
            {
                return;
            }

            throw new ArgumentException("localizedResourceId is null.");
        }


    }
}