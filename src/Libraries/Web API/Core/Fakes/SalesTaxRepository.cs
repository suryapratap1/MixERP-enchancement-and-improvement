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
    public class SalesTaxRepository : ISalesTaxRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTax(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTax(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTax Get(int salesTaxId)
        {
            return new MixERP.Net.Entities.Core.SalesTax();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> Get(int[] salesTaxIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTax(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTax GetFirst()
        {
            return new MixERP.Net.Entities.Core.SalesTax();
        }

        public MixERP.Net.Entities.Core.SalesTax GetPrevious(int salesTaxId)
        {
            return new MixERP.Net.Entities.Core.SalesTax();
        }

        public MixERP.Net.Entities.Core.SalesTax GetNext(int salesTaxId)
        {
            return new MixERP.Net.Entities.Core.SalesTax();
        }

        public MixERP.Net.Entities.Core.SalesTax GetLast()
        {
            return new MixERP.Net.Entities.Core.SalesTax();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTax(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTax(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTax(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTax> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTax(), 1);
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

        public object AddOrEdit(dynamic salesTax, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic salesTax, int salesTaxId)
        {
            if (salesTaxId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxId is null.");
        }

        public object Add(dynamic salesTax)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> salesTaxes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int salesTaxId)
        {
            if (salesTaxId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxId is null.");
        }


    }
}