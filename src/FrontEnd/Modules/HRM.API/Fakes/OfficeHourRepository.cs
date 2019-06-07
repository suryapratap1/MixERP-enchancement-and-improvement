// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Core.Modules.HRM.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.HRM.Fakes
{
    public class OfficeHourRepository : IOfficeHourRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.OfficeHour(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.OfficeHour(), 1);
        }

        public MixERP.Net.Entities.HRM.OfficeHour Get(int officeHourId)
        {
            return new MixERP.Net.Entities.HRM.OfficeHour();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> Get(int[] officeHourIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.OfficeHour(), 1);
        }

        public MixERP.Net.Entities.HRM.OfficeHour GetFirst()
        {
            return new MixERP.Net.Entities.HRM.OfficeHour();
        }

        public MixERP.Net.Entities.HRM.OfficeHour GetPrevious(int officeHourId)
        {
            return new MixERP.Net.Entities.HRM.OfficeHour();
        }

        public MixERP.Net.Entities.HRM.OfficeHour GetNext(int officeHourId)
        {
            return new MixERP.Net.Entities.HRM.OfficeHour();
        }

        public MixERP.Net.Entities.HRM.OfficeHour GetLast()
        {
            return new MixERP.Net.Entities.HRM.OfficeHour();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.OfficeHour(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.OfficeHour(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.OfficeHour(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.OfficeHour> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.OfficeHour(), 1);
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

        public object AddOrEdit(dynamic officeHour, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic officeHour, int officeHourId)
        {
            if (officeHourId > 0)
            {
                return;
            }

            throw new ArgumentException("officeHourId is null.");
        }

        public object Add(dynamic officeHour)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> officeHours)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int officeHourId)
        {
            if (officeHourId > 0)
            {
                return;
            }

            throw new ArgumentException("officeHourId is null.");
        }


    }
}