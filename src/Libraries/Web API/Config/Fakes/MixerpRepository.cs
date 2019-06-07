// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Config.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Config.Fakes
{
    public class MixerpRepository : IMixerpRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Mixerp(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Mixerp(), 1);
        }

        public MixERP.Net.Entities.Config.Mixerp Get(string key)
        {
            return new MixERP.Net.Entities.Config.Mixerp();
        }

        public IEnumerable<MixERP.Net.Entities.Config.Mixerp> Get(string[] keys)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Mixerp(), 1);
        }

        public MixERP.Net.Entities.Config.Mixerp GetFirst()
        {
            return new MixERP.Net.Entities.Config.Mixerp();
        }

        public MixERP.Net.Entities.Config.Mixerp GetPrevious(string key)
        {
            return new MixERP.Net.Entities.Config.Mixerp();
        }

        public MixERP.Net.Entities.Config.Mixerp GetNext(string key)
        {
            return new MixERP.Net.Entities.Config.Mixerp();
        }

        public MixERP.Net.Entities.Config.Mixerp GetLast()
        {
            return new MixERP.Net.Entities.Config.Mixerp();
        }

        public IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Mixerp(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Mixerp(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Mixerp(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Config.Mixerp> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.Mixerp(), 1);
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

        public object AddOrEdit(dynamic mixerp, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic mixerp, string key)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            throw new ArgumentException("key is null.");
        }

        public object Add(dynamic mixerp)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> mixerps)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string key)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            throw new ArgumentException("key is null.");
        }


    }
}