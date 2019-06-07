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
    public class LateFeeRepository : ILateFeeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.LateFee> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.LateFee(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.LateFee(), 1);
        }

        public MixERP.Net.Entities.Transactions.LateFee Get(long transactionMasterId)
        {
            return new MixERP.Net.Entities.Transactions.LateFee();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.LateFee> Get([FromUri] long[] transactionMasterIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.LateFee(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.LateFee> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.LateFee(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.LateFee> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.LateFee(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.LateFee> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.LateFee(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.LateFee> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.LateFee(), 1);
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

        public object AddOrEdit(dynamic lateFee, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic lateFee, long transactionMasterId)
        {
            if (transactionMasterId > 0)
            {
                return;
            }

            throw new ArgumentException("transactionMasterId is null.");
        }

        public object Add(dynamic lateFee)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> lateFees)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long transactionMasterId)
        {
            if (transactionMasterId > 0)
            {
                return;
            }

            throw new ArgumentException("transactionMasterId is null.");
        }


    }
}