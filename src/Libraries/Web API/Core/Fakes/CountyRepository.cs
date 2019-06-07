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
    public class CountyRepository : ICountyRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.County> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.County(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.County(), 1);
        }

        public MixERP.Net.Entities.Core.County Get(int countyId)
        {
            return new MixERP.Net.Entities.Core.County();
        }

        public IEnumerable<MixERP.Net.Entities.Core.County> Get(int[] countyIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.County(), 1);
        }

        public MixERP.Net.Entities.Core.County GetFirst()
        {
            return new MixERP.Net.Entities.Core.County();
        }

        public MixERP.Net.Entities.Core.County GetPrevious(int countyId)
        {
            return new MixERP.Net.Entities.Core.County();
        }

        public MixERP.Net.Entities.Core.County GetNext(int countyId)
        {
            return new MixERP.Net.Entities.Core.County();
        }

        public MixERP.Net.Entities.Core.County GetLast()
        {
            return new MixERP.Net.Entities.Core.County();
        }

        public IEnumerable<MixERP.Net.Entities.Core.County> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.County(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.County> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.County(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.County> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.County(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.County> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.County(), 1);
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

        public object AddOrEdit(dynamic county, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic county, int countyId)
        {
            if (countyId > 0)
            {
                return;
            }

            throw new ArgumentException("countyId is null.");
        }

        public object Add(dynamic county)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> counties)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int countyId)
        {
            if (countyId > 0)
            {
                return;
            }

            throw new ArgumentException("countyId is null.");
        }


    }
}