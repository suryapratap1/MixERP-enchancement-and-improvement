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
    public class FlagTypeRepository : IFlagTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.FlagType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FlagType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FlagType(), 1);
        }

        public MixERP.Net.Entities.Core.FlagType Get(int flagTypeId)
        {
            return new MixERP.Net.Entities.Core.FlagType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.FlagType> Get(int[] flagTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FlagType(), 1);
        }

        public MixERP.Net.Entities.Core.FlagType GetFirst()
        {
            return new MixERP.Net.Entities.Core.FlagType();
        }

        public MixERP.Net.Entities.Core.FlagType GetPrevious(int flagTypeId)
        {
            return new MixERP.Net.Entities.Core.FlagType();
        }

        public MixERP.Net.Entities.Core.FlagType GetNext(int flagTypeId)
        {
            return new MixERP.Net.Entities.Core.FlagType();
        }

        public MixERP.Net.Entities.Core.FlagType GetLast()
        {
            return new MixERP.Net.Entities.Core.FlagType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.FlagType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FlagType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.FlagType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FlagType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.FlagType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FlagType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.FlagType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.FlagType(), 1);
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

        public object AddOrEdit(dynamic flagType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic flagType, int flagTypeId)
        {
            if (flagTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("flagTypeId is null.");
        }

        public object Add(dynamic flagType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> flagTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int flagTypeId)
        {
            if (flagTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("flagTypeId is null.");
        }


    }
}