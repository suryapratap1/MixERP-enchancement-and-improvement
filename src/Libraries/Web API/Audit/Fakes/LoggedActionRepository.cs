// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Audit.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Audit.Fakes
{
    public class LoggedActionRepository : ILoggedActionRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.LoggedAction(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.LoggedAction(), 1);
        }

        public MixERP.Net.Entities.Audit.LoggedAction Get(long eventId)
        {
            return new MixERP.Net.Entities.Audit.LoggedAction();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> Get(long[] eventIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.LoggedAction(), 1);
        }

        public MixERP.Net.Entities.Audit.LoggedAction GetFirst()
        {
            return new MixERP.Net.Entities.Audit.LoggedAction();
        }

        public MixERP.Net.Entities.Audit.LoggedAction GetPrevious(long eventId)
        {
            return new MixERP.Net.Entities.Audit.LoggedAction();
        }

        public MixERP.Net.Entities.Audit.LoggedAction GetNext(long eventId)
        {
            return new MixERP.Net.Entities.Audit.LoggedAction();
        }

        public MixERP.Net.Entities.Audit.LoggedAction GetLast()
        {
            return new MixERP.Net.Entities.Audit.LoggedAction();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.LoggedAction(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.LoggedAction(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.LoggedAction(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Audit.LoggedAction> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Audit.LoggedAction(), 1);
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

        public object AddOrEdit(dynamic loggedAction, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic loggedAction, long eventId)
        {
            if (eventId > 0)
            {
                return;
            }

            throw new ArgumentException("eventId is null.");
        }

        public object Add(dynamic loggedAction)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> loggedActions)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long eventId)
        {
            if (eventId > 0)
            {
                return;
            }

            throw new ArgumentException("eventId is null.");
        }


    }
}