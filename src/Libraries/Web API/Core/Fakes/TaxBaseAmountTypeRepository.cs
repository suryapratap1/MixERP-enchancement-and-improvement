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
    public class TaxBaseAmountTypeRepository : ITaxBaseAmountTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxBaseAmountType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxBaseAmountType(), 1);
        }

        public MixERP.Net.Entities.Core.TaxBaseAmountType Get(string taxBaseAmountTypeCode)
        {
            return new MixERP.Net.Entities.Core.TaxBaseAmountType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> Get(string[] taxBaseAmountTypeCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxBaseAmountType(), 1);
        }

        public MixERP.Net.Entities.Core.TaxBaseAmountType GetFirst()
        {
            return new MixERP.Net.Entities.Core.TaxBaseAmountType();
        }

        public MixERP.Net.Entities.Core.TaxBaseAmountType GetPrevious(string taxBaseAmountTypeCode)
        {
            return new MixERP.Net.Entities.Core.TaxBaseAmountType();
        }

        public MixERP.Net.Entities.Core.TaxBaseAmountType GetNext(string taxBaseAmountTypeCode)
        {
            return new MixERP.Net.Entities.Core.TaxBaseAmountType();
        }

        public MixERP.Net.Entities.Core.TaxBaseAmountType GetLast()
        {
            return new MixERP.Net.Entities.Core.TaxBaseAmountType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxBaseAmountType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxBaseAmountType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxBaseAmountType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxBaseAmountType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxBaseAmountType(), 1);
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

        public object AddOrEdit(dynamic taxBaseAmountType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic taxBaseAmountType, string taxBaseAmountTypeCode)
        {
            if (!string.IsNullOrWhiteSpace(taxBaseAmountTypeCode))
            {
                return;
            }

            throw new ArgumentException("taxBaseAmountTypeCode is null.");
        }

        public object Add(dynamic taxBaseAmountType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> taxBaseAmountTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string taxBaseAmountTypeCode)
        {
            if (!string.IsNullOrWhiteSpace(taxBaseAmountTypeCode))
            {
                return;
            }

            throw new ArgumentException("taxBaseAmountTypeCode is null.");
        }


    }
}