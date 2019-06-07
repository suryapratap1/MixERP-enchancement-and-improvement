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
    public class DbParameterRepository : IDbParameterRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.DbParameter(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.DbParameter(), 1);
        }

        public MixERP.Net.Entities.Config.DbParameter Get(string key)
        {
            return new MixERP.Net.Entities.Config.DbParameter();
        }

        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> Get(string[] keys)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.DbParameter(), 1);
        }

        public MixERP.Net.Entities.Config.DbParameter GetFirst()
        {
            return new MixERP.Net.Entities.Config.DbParameter();
        }

        public MixERP.Net.Entities.Config.DbParameter GetPrevious(string key)
        {
            return new MixERP.Net.Entities.Config.DbParameter();
        }

        public MixERP.Net.Entities.Config.DbParameter GetNext(string key)
        {
            return new MixERP.Net.Entities.Config.DbParameter();
        }

        public MixERP.Net.Entities.Config.DbParameter GetLast()
        {
            return new MixERP.Net.Entities.Config.DbParameter();
        }

        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.DbParameter(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.DbParameter(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.DbParameter(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Config.DbParameter> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Config.DbParameter(), 1);
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

        public object AddOrEdit(dynamic dbParameter, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic dbParameter, string key)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            throw new ArgumentException("key is null.");
        }

        public object Add(dynamic dbParameter)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> dbParameters)
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