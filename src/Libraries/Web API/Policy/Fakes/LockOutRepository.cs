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
    public class LockOutRepository : ILockOutRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.LockOut(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.LockOut(), 1);
        }

        public MixERP.Net.Entities.Policy.LockOut Get(long lockOutId)
        {
            return new MixERP.Net.Entities.Policy.LockOut();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> Get(long[] lockOutIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.LockOut(), 1);
        }

        public MixERP.Net.Entities.Policy.LockOut GetFirst()
        {
            return new MixERP.Net.Entities.Policy.LockOut();
        }

        public MixERP.Net.Entities.Policy.LockOut GetPrevious(long lockOutId)
        {
            return new MixERP.Net.Entities.Policy.LockOut();
        }

        public MixERP.Net.Entities.Policy.LockOut GetNext(long lockOutId)
        {
            return new MixERP.Net.Entities.Policy.LockOut();
        }

        public MixERP.Net.Entities.Policy.LockOut GetLast()
        {
            return new MixERP.Net.Entities.Policy.LockOut();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.LockOut(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.LockOut(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.LockOut(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Policy.LockOut> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Policy.LockOut(), 1);
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

        public object AddOrEdit(dynamic lockOut, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic lockOut, long lockOutId)
        {
            if (lockOutId > 0)
            {
                return;
            }

            throw new ArgumentException("lockOutId is null.");
        }

        public object Add(dynamic lockOut)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> lockOuts)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long lockOutId)
        {
            if (lockOutId > 0)
            {
                return;
            }

            throw new ArgumentException("lockOutId is null.");
        }


    }
}