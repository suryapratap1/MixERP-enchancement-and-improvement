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
    public class BankAccountRepository : IBankAccountRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BankAccount(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BankAccount(), 1);
        }

        public MixERP.Net.Entities.Core.BankAccount Get(long accountId)
        {
            return new MixERP.Net.Entities.Core.BankAccount();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BankAccount> Get(long[] accountIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BankAccount(), 1);
        }

        public MixERP.Net.Entities.Core.BankAccount GetFirst()
        {
            return new MixERP.Net.Entities.Core.BankAccount();
        }

        public MixERP.Net.Entities.Core.BankAccount GetPrevious(long accountId)
        {
            return new MixERP.Net.Entities.Core.BankAccount();
        }

        public MixERP.Net.Entities.Core.BankAccount GetNext(long accountId)
        {
            return new MixERP.Net.Entities.Core.BankAccount();
        }

        public MixERP.Net.Entities.Core.BankAccount GetLast()
        {
            return new MixERP.Net.Entities.Core.BankAccount();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BankAccount(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BankAccount(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BankAccount(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BankAccount> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BankAccount(), 1);
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

        public object AddOrEdit(dynamic bankAccount, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic bankAccount, long bankAccountId)
        {
            if (bankAccountId > 0)
            {
                return;
            }

            throw new ArgumentException("accountId is null.");
        }

        public object Add(dynamic bankAccount)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> bankAccounts)
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


    }
}