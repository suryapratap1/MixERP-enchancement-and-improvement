// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Policy.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Policy.Fakes
{
    public class HttpActionRepository : IHttpActionRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.HttpAction(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.HttpAction(), 1);
        }

        public MixERP.Net.Entities.Policy.HttpAction Get(string httpActionCode)
        {
            return new MixERP.Net.Entities.Policy.HttpAction();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.HttpAction> Get(string[] httpActionCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.HttpAction(), 1);
        }

        public MixERP.Net.Entities.Policy.HttpAction GetFirst()
        {
            return new MixERP.Net.Entities.Policy.HttpAction();
        }

        public MixERP.Net.Entities.Policy.HttpAction GetPrevious(string httpActionCode)
        {
            return new MixERP.Net.Entities.Policy.HttpAction();
        }

        public MixERP.Net.Entities.Policy.HttpAction GetNext(string httpActionCode)
        {
            return new MixERP.Net.Entities.Policy.HttpAction();
        }

        public MixERP.Net.Entities.Policy.HttpAction GetLast()
        {
            return new MixERP.Net.Entities.Policy.HttpAction();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.HttpAction(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.HttpAction(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.HttpAction(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.HttpAction> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.HttpAction(), 1);
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

        public object AddOrEdit(dynamic httpAction, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic httpAction, string httpActionCode)
        {
            if (!string.IsNullOrWhiteSpace(httpActionCode))
            {
                return;
            }

            throw new ArgumentException("httpActionCode is null.");
        }

        public object Add(dynamic httpAction)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> httpActions)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string httpActionCode)
        {
            if (!string.IsNullOrWhiteSpace(httpActionCode))
            {
                return;
            }

            throw new ArgumentException("httpActionCode is null.");
        }


    }
}