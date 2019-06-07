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
    public class CompoundUnitRepository : ICompoundUnitRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundUnit(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundUnit(), 1);
        }

        public MixERP.Net.Entities.Core.CompoundUnit Get(int compoundUnitId)
        {
            return new MixERP.Net.Entities.Core.CompoundUnit();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> Get(int[] compoundUnitIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundUnit(), 1);
        }

        public MixERP.Net.Entities.Core.CompoundUnit GetFirst()
        {
            return new MixERP.Net.Entities.Core.CompoundUnit();
        }

        public MixERP.Net.Entities.Core.CompoundUnit GetPrevious(int compoundUnitId)
        {
            return new MixERP.Net.Entities.Core.CompoundUnit();
        }

        public MixERP.Net.Entities.Core.CompoundUnit GetNext(int compoundUnitId)
        {
            return new MixERP.Net.Entities.Core.CompoundUnit();
        }

        public MixERP.Net.Entities.Core.CompoundUnit GetLast()
        {
            return new MixERP.Net.Entities.Core.CompoundUnit();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundUnit(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundUnit(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundUnit(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundUnit> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundUnit(), 1);
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

        public object AddOrEdit(dynamic compoundUnit, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic compoundUnit, int compoundUnitId)
        {
            if (compoundUnitId > 0)
            {
                return;
            }

            throw new ArgumentException("compoundUnitId is null.");
        }

        public object Add(dynamic compoundUnit)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> compoundUnits)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int compoundUnitId)
        {
            if (compoundUnitId > 0)
            {
                return;
            }

            throw new ArgumentException("compoundUnitId is null.");
        }


    }
}