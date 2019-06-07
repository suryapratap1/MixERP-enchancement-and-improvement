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
    public class SalesTaxExemptDetailRepository : ISalesTaxExemptDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExemptDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExemptDetail(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTaxExemptDetail Get(int salesTaxExemptDetailId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxExemptDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> Get(int[] salesTaxExemptDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExemptDetail(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTaxExemptDetail GetFirst()
        {
            return new MixERP.Net.Entities.Core.SalesTaxExemptDetail();
        }

        public MixERP.Net.Entities.Core.SalesTaxExemptDetail GetPrevious(int salesTaxExemptDetailId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxExemptDetail();
        }

        public MixERP.Net.Entities.Core.SalesTaxExemptDetail GetNext(int salesTaxExemptDetailId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxExemptDetail();
        }

        public MixERP.Net.Entities.Core.SalesTaxExemptDetail GetLast()
        {
            return new MixERP.Net.Entities.Core.SalesTaxExemptDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExemptDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExemptDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExemptDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExemptDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExemptDetail(), 1);
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

        public object AddOrEdit(dynamic salesTaxExemptDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic salesTaxExemptDetail, int salesTaxExemptDetailId)
        {
            if (salesTaxExemptDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxExemptDetailId is null.");
        }

        public object Add(dynamic salesTaxExemptDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> salesTaxExemptDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int salesTaxExemptDetailId)
        {
            if (salesTaxExemptDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxExemptDetailId is null.");
        }


    }
}