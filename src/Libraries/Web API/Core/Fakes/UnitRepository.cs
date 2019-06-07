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
    public class UnitRepository : IUnitRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Unit> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Unit(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Unit(), 1);
        }

        public MixERP.Net.Entities.Core.Unit Get(int unitId)
        {
            return new MixERP.Net.Entities.Core.Unit();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Unit> Get(int[] unitIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Unit(), 1);
        }

        public MixERP.Net.Entities.Core.Unit GetFirst()
        {
            return new MixERP.Net.Entities.Core.Unit();
        }

        public MixERP.Net.Entities.Core.Unit GetPrevious(int unitId)
        {
            return new MixERP.Net.Entities.Core.Unit();
        }

        public MixERP.Net.Entities.Core.Unit GetNext(int unitId)
        {
            return new MixERP.Net.Entities.Core.Unit();
        }

        public MixERP.Net.Entities.Core.Unit GetLast()
        {
            return new MixERP.Net.Entities.Core.Unit();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Unit> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Unit(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Unit> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Unit(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Unit> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Unit(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Unit> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Unit(), 1);
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

        public object AddOrEdit(dynamic unit, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic unit, int unitId)
        {
            if (unitId > 0)
            {
                return;
            }

            throw new ArgumentException("unitId is null.");
        }

        public object Add(dynamic unit)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> units)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int unitId)
        {
            if (unitId > 0)
            {
                return;
            }

            throw new ArgumentException("unitId is null.");
        }


    }
}