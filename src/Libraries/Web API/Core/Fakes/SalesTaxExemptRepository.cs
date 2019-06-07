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
    public class SalesTaxExemptRepository : ISalesTaxExemptRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExempt(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExempt(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTaxExempt Get(int salesTaxExemptId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxExempt();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> Get(int[] salesTaxExemptIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExempt(), 1);
        }

        public MixERP.Net.Entities.Core.SalesTaxExempt GetFirst()
        {
            return new MixERP.Net.Entities.Core.SalesTaxExempt();
        }

        public MixERP.Net.Entities.Core.SalesTaxExempt GetPrevious(int salesTaxExemptId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxExempt();
        }

        public MixERP.Net.Entities.Core.SalesTaxExempt GetNext(int salesTaxExemptId)
        {
            return new MixERP.Net.Entities.Core.SalesTaxExempt();
        }

        public MixERP.Net.Entities.Core.SalesTaxExempt GetLast()
        {
            return new MixERP.Net.Entities.Core.SalesTaxExempt();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExempt(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExempt(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExempt(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalesTaxExempt> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalesTaxExempt(), 1);
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

        public object AddOrEdit(dynamic salesTaxExempt, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic salesTaxExempt, int salesTaxExemptId)
        {
            if (salesTaxExemptId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxExemptId is null.");
        }

        public object Add(dynamic salesTaxExempt)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> salesTaxExempts)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int salesTaxExemptId)
        {
            if (salesTaxExemptId > 0)
            {
                return;
            }

            throw new ArgumentException("salesTaxExemptId is null.");
        }


    }
}