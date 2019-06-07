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
    public class EntityRepository : IEntityRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Entity> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Entity(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Entity(), 1);
        }

        public MixERP.Net.Entities.Core.Entity Get(int entityId)
        {
            return new MixERP.Net.Entities.Core.Entity();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Entity> Get(int[] entityIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Entity(), 1);
        }

        public MixERP.Net.Entities.Core.Entity GetFirst()
        {
            return new MixERP.Net.Entities.Core.Entity();
        }

        public MixERP.Net.Entities.Core.Entity GetPrevious(int entityId)
        {
            return new MixERP.Net.Entities.Core.Entity();
        }

        public MixERP.Net.Entities.Core.Entity GetNext(int entityId)
        {
            return new MixERP.Net.Entities.Core.Entity();
        }

        public MixERP.Net.Entities.Core.Entity GetLast()
        {
            return new MixERP.Net.Entities.Core.Entity();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Entity> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Entity(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Entity> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Entity(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Entity> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Entity(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Entity> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Entity(), 1);
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

        public object AddOrEdit(dynamic entity, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic entity, int entityId)
        {
            if (entityId > 0)
            {
                return;
            }

            throw new ArgumentException("entityId is null.");
        }

        public object Add(dynamic entity)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> entities)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int entityId)
        {
            if (entityId > 0)
            {
                return;
            }

            throw new ArgumentException("entityId is null.");
        }


    }
}