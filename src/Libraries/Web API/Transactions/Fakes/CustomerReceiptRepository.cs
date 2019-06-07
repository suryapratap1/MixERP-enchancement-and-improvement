// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class CustomerReceiptRepository : ICustomerReceiptRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.CustomerReceipt(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.CustomerReceipt(), 1);
        }

        public MixERP.Net.Entities.Transactions.CustomerReceipt Get(long receiptId)
        {
            return new MixERP.Net.Entities.Transactions.CustomerReceipt();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> Get([FromUri] long[] receiptIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.CustomerReceipt(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.CustomerReceipt(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.CustomerReceipt(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.CustomerReceipt(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.CustomerReceipt(), 1);
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

        public object AddOrEdit(dynamic customerReceipt, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic customerReceipt, long receiptId)
        {
            if (receiptId > 0)
            {
                return;
            }

            throw new ArgumentException("receiptId is null.");
        }

        public object Add(dynamic customerReceipt)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> customerReceipts)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long receiptId)
        {
            if (receiptId > 0)
            {
                return;
            }

            throw new ArgumentException("receiptId is null.");
        }


    }
}