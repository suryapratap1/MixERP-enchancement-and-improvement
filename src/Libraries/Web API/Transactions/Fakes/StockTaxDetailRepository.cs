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
    public class StockTaxDetailRepository : IStockTaxDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockTaxDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockTaxDetail(), 1);
        }

        public MixERP.Net.Entities.Transactions.StockTaxDetail Get(long stockTaxDetailId)
        {
            return new MixERP.Net.Entities.Transactions.StockTaxDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> Get([FromUri] long[] stockTaxDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockTaxDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockTaxDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockTaxDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockTaxDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.StockTaxDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.StockTaxDetail(), 1);
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

        public object AddOrEdit(dynamic stockTaxDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic stockTaxDetail, long stockTaxDetailId)
        {
            if (stockTaxDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("stockTaxDetailId is null.");
        }

        public object Add(dynamic stockTaxDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> stockTaxDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long stockTaxDetailId)
        {
            if (stockTaxDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("stockTaxDetailId is null.");
        }


    }
}