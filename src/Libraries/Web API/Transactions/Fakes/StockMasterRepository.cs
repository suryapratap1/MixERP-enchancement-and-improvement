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
    public class StockMasterRepository : IStockMasterRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockMaster(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockMaster(), 1);
        }

        public MixERP.Net.Entities.Transactions.StockMaster Get(long stockMasterId)
        {
            return new MixERP.Net.Entities.Transactions.StockMaster();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> Get([FromUri] long[] stockMasterIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockMaster(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockMaster(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockMaster(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockMaster(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockMaster> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockMaster(), 1);
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

        public object AddOrEdit(dynamic stockMaster, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic stockMaster, long stockMasterId)
        {
            if (stockMasterId > 0)
            {
                return;
            }

            throw new ArgumentException("stockMasterId is null.");
        }

        public object Add(dynamic stockMaster)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> stockMasters)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long stockMasterId)
        {
            if (stockMasterId > 0)
            {
                return;
            }

            throw new ArgumentException("stockMasterId is null.");
        }


    }
}