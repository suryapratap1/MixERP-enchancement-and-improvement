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
    public class GenderRepository : IGenderRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Gender> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Gender(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Gender(), 1);
        }

        public MixERP.Net.Entities.Core.Gender Get(string genderCode)
        {
            return new MixERP.Net.Entities.Core.Gender();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Gender> Get(string[] genderCodes)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Gender(), 1);
        }

        public MixERP.Net.Entities.Core.Gender GetFirst()
        {
            return new MixERP.Net.Entities.Core.Gender();
        }

        public MixERP.Net.Entities.Core.Gender GetPrevious(string genderCode)
        {
            return new MixERP.Net.Entities.Core.Gender();
        }

        public MixERP.Net.Entities.Core.Gender GetNext(string genderCode)
        {
            return new MixERP.Net.Entities.Core.Gender();
        }

        public MixERP.Net.Entities.Core.Gender GetLast()
        {
            return new MixERP.Net.Entities.Core.Gender();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Gender> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Gender(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Gender> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Gender(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Gender> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Gender(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Gender> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Gender(), 1);
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

        public object AddOrEdit(dynamic gender, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic gender, string genderCode)
        {
            if (!string.IsNullOrWhiteSpace(genderCode))
            {
                return;
            }

            throw new ArgumentException("genderCode is null.");
        }

        public object Add(dynamic gender)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> genders)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string genderCode)
        {
            if (!string.IsNullOrWhiteSpace(genderCode))
            {
                return;
            }

            throw new ArgumentException("genderCode is null.");
        }


    }
}