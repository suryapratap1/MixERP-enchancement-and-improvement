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
    public class TransactionTypeRepository : ITransactionTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TransactionType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TransactionType(), 1);
        }

        public MixERP.Net.Entities.Core.TransactionType Get(short transactionTypeId)
        {
            return new MixERP.Net.Entities.Core.TransactionType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TransactionType> Get(short[] transactionTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TransactionType(), 1);
        }

        public MixERP.Net.Entities.Core.TransactionType GetFirst()
        {
            return new MixERP.Net.Entities.Core.TransactionType();
        }

        public MixERP.Net.Entities.Core.TransactionType GetPrevious(short transactionTypeId)
        {
            return new MixERP.Net.Entities.Core.TransactionType();
        }

        public MixERP.Net.Entities.Core.TransactionType GetNext(short transactionTypeId)
        {
            return new MixERP.Net.Entities.Core.TransactionType();
        }

        public MixERP.Net.Entities.Core.TransactionType GetLast()
        {
            return new MixERP.Net.Entities.Core.TransactionType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TransactionType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TransactionType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TransactionType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TransactionType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TransactionType(), 1);
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

        public object AddOrEdit(dynamic transactionType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic transactionType, short transactionTypeId)
        {
            if (transactionTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("transactionTypeId is null.");
        }

        public object Add(dynamic transactionType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> transactionTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(short transactionTypeId)
        {
            if (transactionTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("transactionTypeId is null.");
        }


    }
}