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
    public class TaxExemptTypeRepository : ITaxExemptTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxExemptType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxExemptType(), 1);
        }

        public MixERP.Net.Entities.Core.TaxExemptType Get(int taxExemptTypeId)
        {
            return new MixERP.Net.Entities.Core.TaxExemptType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> Get(int[] taxExemptTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxExemptType(), 1);
        }

        public MixERP.Net.Entities.Core.TaxExemptType GetFirst()
        {
            return new MixERP.Net.Entities.Core.TaxExemptType();
        }

        public MixERP.Net.Entities.Core.TaxExemptType GetPrevious(int taxExemptTypeId)
        {
            return new MixERP.Net.Entities.Core.TaxExemptType();
        }

        public MixERP.Net.Entities.Core.TaxExemptType GetNext(int taxExemptTypeId)
        {
            return new MixERP.Net.Entities.Core.TaxExemptType();
        }

        public MixERP.Net.Entities.Core.TaxExemptType GetLast()
        {
            return new MixERP.Net.Entities.Core.TaxExemptType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxExemptType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxExemptType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxExemptType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.TaxExemptType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.TaxExemptType(), 1);
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

        public object AddOrEdit(dynamic taxExemptType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic taxExemptType, int taxExemptTypeId)
        {
            if (taxExemptTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("taxExemptTypeId is null.");
        }

        public object Add(dynamic taxExemptType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> taxExemptTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int taxExemptTypeId)
        {
            if (taxExemptTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("taxExemptTypeId is null.");
        }


    }
}