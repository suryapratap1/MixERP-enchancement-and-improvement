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
    public class SalesTaxDetailRepository : ISalesTaxDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxDetail(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTaxDetail Get(int salesTaxDetailId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> Get(int[] salesTaxDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxDetail(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTaxDetail GetFirst()
        {
            return new MixERP.Net.Entities.Core.SalesTaxDetail();
        }

        public MixERP.Net.Entities.Core.SalesTaxDetail GetPrevious(int salesTaxDetailId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxDetail();
        }

        public MixERP.Net.Entities.Core.SalesTaxDetail GetNext(int salesTaxDetailId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxDetail();
        }

        public MixERP.Net.Entities.Core.SalesTaxDetail GetLast()
        {
            return new MixERP.Net.Entities.Core.SalesTaxDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxDetail(), 1);
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

        public object AddOrEdit(dynamic salesTaxDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic salesTaxDetail, int salesTaxDetailId)
        {
            if (salesTaxDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxDetailId is null.");
        }

        public object Add(dynamic salesTaxDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> salesTaxDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int salesTaxDetailId)
        {
            if (salesTaxDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxDetailId is null.");
        }


    }
}