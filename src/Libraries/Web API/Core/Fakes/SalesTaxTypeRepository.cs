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
    public class SalesTaxTypeRepository : ISalesTaxTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxType(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTaxType Get(int salesTaxTypeId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> Get(int[] salesTaxTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxType(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTaxType GetFirst()
        {
            return new MixERP.Net.Entities.Core.SalesTaxType();
        }

        public MixERP.Net.Entities.Core.SalesTaxType GetPrevious(int salesTaxTypeId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxType();
        }

        public MixERP.Net.Entities.Core.SalesTaxType GetNext(int salesTaxTypeId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxType();
        }

        public MixERP.Net.Entities.Core.SalesTaxType GetLast()
        {
            return new MixERP.Net.Entities.Core.SalesTaxType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxType(), 1);
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

        public object AddOrEdit(dynamic salesTaxType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic salesTaxType, int salesTaxTypeId)
        {
            if (salesTaxTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxTypeId is null.");
        }

        public object Add(dynamic salesTaxType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> salesTaxTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int salesTaxTypeId)
        {
            if (salesTaxTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxTypeId is null.");
        }


    }
}