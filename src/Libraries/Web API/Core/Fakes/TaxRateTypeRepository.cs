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
    public class TaxRateTypeRepository : ITaxRateTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxRateType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxRateType(), 1);
        }

        public MixERP.Net.Entities.Core.TaxRateType Get(string taxRateTypeCode)
        {
            return new MixERP.Net.Entities.Core.TaxRateType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxRateType> Get(string[] taxRateTypeCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxRateType(), 1);
        }

        public MixERP.Net.Entities.Core.TaxRateType GetFirst()
        {
            return new MixERP.Net.Entities.Core.TaxRateType();
        }

        public MixERP.Net.Entities.Core.TaxRateType GetPrevious(string taxRateTypeCode)
        {
            return new MixERP.Net.Entities.Core.TaxRateType();
        }

        public MixERP.Net.Entities.Core.TaxRateType GetNext(string taxRateTypeCode)
        {
            return new MixERP.Net.Entities.Core.TaxRateType();
        }

        public MixERP.Net.Entities.Core.TaxRateType GetLast()
        {
            return new MixERP.Net.Entities.Core.TaxRateType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxRateType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxRateType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxRateType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxRateType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxRateType(), 1);
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

        public object AddOrEdit(dynamic taxRateType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic taxRateType, string taxRateTypeCode)
        {
            if (!string.IsNullOrWhiteSpace(taxRateTypeCode))
            {
                return;
            }

            throw new ArgumentException("taxRateTypeCode is null.");
        }

        public object Add(dynamic taxRateType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> taxRateTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string taxRateTypeCode)
        {
            if (!string.IsNullOrWhiteSpace(taxRateTypeCode))
            {
                return;
            }

            throw new ArgumentException("taxRateTypeCode is null.");
        }


    }
}