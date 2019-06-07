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
    public class TransactionDetailRepository : ITransactionDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.TransactionDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.TransactionDetail(), 1);
        }

        public MixERP.Net.Entities.Transactions.TransactionDetail Get(long transactionDetailId)
        {
            return new MixERP.Net.Entities.Transactions.TransactionDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> Get([FromUri] long[] transactionDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.TransactionDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.TransactionDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.TransactionDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.TransactionDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.TransactionDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.TransactionDetail(), 1);
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

        public object AddOrEdit(dynamic transactionDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic transactionDetail, long transactionDetailId)
        {
            if (transactionDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("transactionDetailId is null.");
        }

        public object Add(dynamic transactionDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> transactionDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long transactionDetailId)
        {
            if (transactionDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("transactionDetailId is null.");
        }


    }
}