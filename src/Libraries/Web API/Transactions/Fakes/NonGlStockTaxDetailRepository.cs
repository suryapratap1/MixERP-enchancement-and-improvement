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
    public class NonGlStockTaxDetailRepository : INonGlStockTaxDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), 1);
        }

        public MixERP.Net.Entities.Transactions.NonGlStockTaxDetail Get(long nonGlStockTaxDetailId)
        {
            return new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> Get([FromUri] long[] nonGlStockTaxDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockTaxDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.NonGlStockTaxDetail(), 1);
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

        public object AddOrEdit(dynamic nonGlStockTaxDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic nonGlStockTaxDetail, long nonGlStockTaxDetailId)
        {
            if (nonGlStockTaxDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("nonGlStockTaxDetailId is null.");
        }

        public object Add(dynamic nonGlStockTaxDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> nonGlStockTaxDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long nonGlStockTaxDetailId)
        {
            if (nonGlStockTaxDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("nonGlStockTaxDetailId is null.");
        }


    }
}