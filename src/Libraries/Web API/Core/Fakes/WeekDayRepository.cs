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
    public class WeekDayRepository : IWeekDayRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WeekDay(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WeekDay(), 1);
        }

        public MixERP.Net.Entities.Core.WeekDay Get(int weekDayId)
        {
            return new MixERP.Net.Entities.Core.WeekDay();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WeekDay> Get(int[] weekDayIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WeekDay(), 1);
        }

        public MixERP.Net.Entities.Core.WeekDay GetFirst()
        {
            return new MixERP.Net.Entities.Core.WeekDay();
        }

        public MixERP.Net.Entities.Core.WeekDay GetPrevious(int weekDayId)
        {
            return new MixERP.Net.Entities.Core.WeekDay();
        }

        public MixERP.Net.Entities.Core.WeekDay GetNext(int weekDayId)
        {
            return new MixERP.Net.Entities.Core.WeekDay();
        }

        public MixERP.Net.Entities.Core.WeekDay GetLast()
        {
            return new MixERP.Net.Entities.Core.WeekDay();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WeekDay(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WeekDay(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WeekDay(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WeekDay> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WeekDay(), 1);
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

        public object AddOrEdit(dynamic weekDay, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic weekDay, int weekDayId)
        {
            if (weekDayId > 0)
            {
                return;
            }

            throw new ArgumentException("weekDayId is null.");
        }

        public object Add(dynamic weekDay)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> weekDays)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int weekDayId)
        {
            if (weekDayId > 0)
            {
                return;
            }

            throw new ArgumentException("weekDayId is null.");
        }


    }
}