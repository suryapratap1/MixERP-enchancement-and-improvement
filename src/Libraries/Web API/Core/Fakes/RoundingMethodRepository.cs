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
    public class RoundingMethodRepository : IRoundingMethodRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RoundingMethod(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RoundingMethod(), 1);
        }

        public MixERP.Net.Entities.Core.RoundingMethod Get(string roundingMethodCode)
        {
            return new MixERP.Net.Entities.Core.RoundingMethod();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> Get(string[] roundingMethodCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RoundingMethod(), 1);
        }

        public MixERP.Net.Entities.Core.RoundingMethod GetFirst()
        {
            return new MixERP.Net.Entities.Core.RoundingMethod();
        }

        public MixERP.Net.Entities.Core.RoundingMethod GetPrevious(string roundingMethodCode)
        {
            return new MixERP.Net.Entities.Core.RoundingMethod();
        }

        public MixERP.Net.Entities.Core.RoundingMethod GetNext(string roundingMethodCode)
        {
            return new MixERP.Net.Entities.Core.RoundingMethod();
        }

        public MixERP.Net.Entities.Core.RoundingMethod GetLast()
        {
            return new MixERP.Net.Entities.Core.RoundingMethod();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RoundingMethod(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RoundingMethod(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RoundingMethod(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RoundingMethod> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RoundingMethod(), 1);
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

        public object AddOrEdit(dynamic roundingMethod, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic roundingMethod, string roundingMethodCode)
        {
            if (!string.IsNullOrWhiteSpace(roundingMethodCode))
            {
                return;
            }

            throw new ArgumentException("roundingMethodCode is null.");
        }

        public object Add(dynamic roundingMethod)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> roundingMethods)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string roundingMethodCode)
        {
            if (!string.IsNullOrWhiteSpace(roundingMethodCode))
            {
                return;
            }

            throw new ArgumentException("roundingMethodCode is null.");
        }


    }
}