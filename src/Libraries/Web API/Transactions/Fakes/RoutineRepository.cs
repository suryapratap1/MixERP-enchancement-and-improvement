// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class RoutineRepository : IRoutineRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.Routine(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.Routine(), 1);
        }

        public MixERP.Net.Entities.Transactions.Routine Get(int routineId)
        {
            return new MixERP.Net.Entities.Transactions.Routine();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.Routine> Get([FromUri] int[] routineIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.Routine(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.Routine(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.Routine(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.Routine(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.Routine> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.Routine(), 1);
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

        public object AddOrEdit(dynamic routine, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic routine, int routineId)
        {
            if (routineId > 0)
            {
                return;
            }

            throw new ArgumentException("routineId is null.");
        }

        public object Add(dynamic routine)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> routines)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int routineId)
        {
            if (routineId > 0)
            {
                return;
            }

            throw new ArgumentException("routineId is null.");
        }


    }
}