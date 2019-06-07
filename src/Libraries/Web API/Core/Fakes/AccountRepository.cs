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
    public class AccountRepository : IAccountRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Account> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
        }

        public MixERP.Net.Entities.Core.Account Get(long accountId)
        {
            return new MixERP.Net.Entities.Core.Account();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Account> Get(long[] accountIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
        }

        public MixERP.Net.Entities.Core.Account GetFirst()
        {
            return new MixERP.Net.Entities.Core.Account();
        }

        public MixERP.Net.Entities.Core.Account GetPrevious(long accountId)
        {
            return new MixERP.Net.Entities.Core.Account();
        }

        public MixERP.Net.Entities.Core.Account GetNext(long accountId)
        {
            return new MixERP.Net.Entities.Core.Account();
        }

        public MixERP.Net.Entities.Core.Account GetLast()
        {
            return new MixERP.Net.Entities.Core.Account();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Account> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Account> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Account> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Account> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
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

        public object AddOrEdit(dynamic account, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic account, long accountId)
        {
            if (accountId > 0)
            {
                return;
            }

            throw new ArgumentException("accountId is null.");
        }

        public object Add(dynamic account)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> accounts)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long accountId)
        {
            if (accountId > 0)
            {
                return;
            }

            throw new ArgumentException("accountId is null.");
        }

        public IEnumerable<MixERP.Net.Entities.Core.Account> GetMultipleByAccountNumbers(string[] accountNumbers)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Account> GetMultipleByAccountNames(string[] accountNames)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Account(), 1);
        }

    }
}