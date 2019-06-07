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
    public class VariantRepository : IVariantRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Variant> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Variant(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Variant(), 1);
        }

        public MixERP.Net.Entities.Core.Variant Get(int variantId)
        {
            return new MixERP.Net.Entities.Core.Variant();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Variant> Get(int[] variantIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Variant(), 1);
        }

        public MixERP.Net.Entities.Core.Variant GetFirst()
        {
            return new MixERP.Net.Entities.Core.Variant();
        }

        public MixERP.Net.Entities.Core.Variant GetPrevious(int variantId)
        {
            return new MixERP.Net.Entities.Core.Variant();
        }

        public MixERP.Net.Entities.Core.Variant GetNext(int variantId)
        {
            return new MixERP.Net.Entities.Core.Variant();
        }

        public MixERP.Net.Entities.Core.Variant GetLast()
        {
            return new MixERP.Net.Entities.Core.Variant();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Variant> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Variant(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Variant> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Variant(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Variant> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Variant(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Variant> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Variant(), 1);
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

        public object AddOrEdit(dynamic variant, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic variant, int variantId)
        {
            if (variantId > 0)
            {
                return;
            }

            throw new ArgumentException("variantId is null.");
        }

        public object Add(dynamic variant)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> variants)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int variantId)
        {
            if (variantId > 0)
            {
                return;
            }

            throw new ArgumentException("variantId is null.");
        }


    }
}