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
    public class RecurrenceTypeRepository : IRecurrenceTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurrenceType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurrenceType(), 1);
        }

        public MixERP.Net.Entities.Core.RecurrenceType Get(int recurrenceTypeId)
        {
            return new MixERP.Net.Entities.Core.RecurrenceType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> Get(int[] recurrenceTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurrenceType(), 1);
        }

        public MixERP.Net.Entities.Core.RecurrenceType GetFirst()
        {
            return new MixERP.Net.Entities.Core.RecurrenceType();
        }

        public MixERP.Net.Entities.Core.RecurrenceType GetPrevious(int recurrenceTypeId)
        {
            return new MixERP.Net.Entities.Core.RecurrenceType();
        }

        public MixERP.Net.Entities.Core.RecurrenceType GetNext(int recurrenceTypeId)
        {
            return new MixERP.Net.Entities.Core.RecurrenceType();
        }

        public MixERP.Net.Entities.Core.RecurrenceType GetLast()
        {
            return new MixERP.Net.Entities.Core.RecurrenceType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurrenceType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurrenceType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurrenceType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurrenceType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurrenceType(), 1);
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

        public object AddOrEdit(dynamic recurrenceType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic recurrenceType, int recurrenceTypeId)
        {
            if (recurrenceTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("recurrenceTypeId is null.");
        }

        public object Add(dynamic recurrenceType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> recurrenceTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int recurrenceTypeId)
        {
            if (recurrenceTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("recurrenceTypeId is null.");
        }


    }
}