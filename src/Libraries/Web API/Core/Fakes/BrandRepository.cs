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
    public class BrandRepository : IBrandRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Brand> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Brand(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Brand(), 1);
        }

        public MixERP.Net.Entities.Core.Brand Get(int brandId)
        {
            return new MixERP.Net.Entities.Core.Brand();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Brand> Get(int[] brandIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Brand(), 1);
        }

        public MixERP.Net.Entities.Core.Brand GetFirst()
        {
            return new MixERP.Net.Entities.Core.Brand();
        }

        public MixERP.Net.Entities.Core.Brand GetPrevious(int brandId)
        {
            return new MixERP.Net.Entities.Core.Brand();
        }

        public MixERP.Net.Entities.Core.Brand GetNext(int brandId)
        {
            return new MixERP.Net.Entities.Core.Brand();
        }

        public MixERP.Net.Entities.Core.Brand GetLast()
        {
            return new MixERP.Net.Entities.Core.Brand();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Brand> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Brand(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Brand> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Brand(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Brand> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Brand(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Brand> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Brand(), 1);
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

        public object AddOrEdit(dynamic brand, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic brand, int brandId)
        {
            if (brandId > 0)
            {
                return;
            }

            throw new ArgumentException("brandId is null.");
        }

        public object Add(dynamic brand)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> brands)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int brandId)
        {
            if (brandId > 0)
            {
                return;
            }

            throw new ArgumentException("brandId is null.");
        }


    }
}