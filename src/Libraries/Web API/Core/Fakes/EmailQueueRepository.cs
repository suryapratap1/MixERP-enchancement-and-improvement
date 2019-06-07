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
    public class EmailQueueRepository : IEmailQueueRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.EmailQueue(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.EmailQueue(), 1);
        }

        public MixERP.Net.Entities.Core.EmailQueue Get(long queueId)
        {
            return new MixERP.Net.Entities.Core.EmailQueue();
        }

        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> Get(long[] queueIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.EmailQueue(), 1);
        }

        public MixERP.Net.Entities.Core.EmailQueue GetFirst()
        {
            return new MixERP.Net.Entities.Core.EmailQueue();
        }

        public MixERP.Net.Entities.Core.EmailQueue GetPrevious(long queueId)
        {
            return new MixERP.Net.Entities.Core.EmailQueue();
        }

        public MixERP.Net.Entities.Core.EmailQueue GetNext(long queueId)
        {
            return new MixERP.Net.Entities.Core.EmailQueue();
        }

        public MixERP.Net.Entities.Core.EmailQueue GetLast()
        {
            return new MixERP.Net.Entities.Core.EmailQueue();
        }

        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.EmailQueue(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.EmailQueue(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.EmailQueue(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.EmailQueue> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.EmailQueue(), 1);
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

        public object AddOrEdit(dynamic emailQueue, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic emailQueue, long queueId)
        {
            if (queueId > 0)
            {
                return;
            }

            throw new ArgumentException("queueId is null.");
        }

        public object Add(dynamic emailQueue)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> emailQueues)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long queueId)
        {
            if (queueId > 0)
            {
                return;
            }

            throw new ArgumentException("queueId is null.");
        }


    }
}