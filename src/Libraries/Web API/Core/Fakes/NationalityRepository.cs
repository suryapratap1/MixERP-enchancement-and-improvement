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
    public class NationalityRepository : INationalityRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Nationality> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Nationality(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Nationality(), 1);
        }

        public MixERP.Net.Entities.Core.Nationality Get(string nationalityCode)
        {
            return new MixERP.Net.Entities.Core.Nationality();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Nationality> Get(string[] nationalityCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Nationality(), 1);
        }

        public MixERP.Net.Entities.Core.Nationality GetFirst()
        {
            return new MixERP.Net.Entities.Core.Nationality();
        }

        public MixERP.Net.Entities.Core.Nationality GetPrevious(string nationalityCode)
        {
            return new MixERP.Net.Entities.Core.Nationality();
        }

        public MixERP.Net.Entities.Core.Nationality GetNext(string nationalityCode)
        {
            return new MixERP.Net.Entities.Core.Nationality();
        }

        public MixERP.Net.Entities.Core.Nationality GetLast()
        {
            return new MixERP.Net.Entities.Core.Nationality();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Nationality> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Nationality(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Nationality> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Nationality(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Nationality> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Nationality(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Nationality> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Nationality(), 1);
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

        public object AddOrEdit(dynamic nationality, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic nationality, string nationalityCode)
        {
            if (!string.IsNullOrWhiteSpace(nationalityCode))
            {
                return;
            }

            throw new ArgumentException("nationalityCode is null.");
        }

        public object Add(dynamic nationality)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> nationalities)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string nationalityCode)
        {
            if (!string.IsNullOrWhiteSpace(nationalityCode))
            {
                return;
            }

            throw new ArgumentException("nationalityCode is null.");
        }


    }
}