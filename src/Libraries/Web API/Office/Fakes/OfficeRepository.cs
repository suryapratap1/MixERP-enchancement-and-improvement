// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Office.Fakes
{
    public class OfficeRepository : IOfficeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Office> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Office(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Office(), 1);
        }

        public MixERP.Net.Entities.Office.Office Get(int officeId)
        {
            return new MixERP.Net.Entities.Office.Office();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Office> Get(int[] officeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Office(), 1);
        }

        public MixERP.Net.Entities.Office.Office GetFirst()
        {
            return new MixERP.Net.Entities.Office.Office();
        }

        public MixERP.Net.Entities.Office.Office GetPrevious(int officeId)
        {
            return new MixERP.Net.Entities.Office.Office();
        }

        public MixERP.Net.Entities.Office.Office GetNext(int officeId)
        {
            return new MixERP.Net.Entities.Office.Office();
        }

        public MixERP.Net.Entities.Office.Office GetLast()
        {
            return new MixERP.Net.Entities.Office.Office();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Office> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Office(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.Office> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Office(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.Office> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Office(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Office.Office> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.Office(), 1);
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

        public object AddOrEdit(dynamic office, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic office, int officeId)
        {
            if (officeId > 0)
            {
                return;
            }

            throw new ArgumentException("officeId is null.");
        }

        public object Add(dynamic office)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> offices)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int officeId)
        {
            if (officeId > 0)
            {
                return;
            }

            throw new ArgumentException("officeId is null.");
        }


    }
}