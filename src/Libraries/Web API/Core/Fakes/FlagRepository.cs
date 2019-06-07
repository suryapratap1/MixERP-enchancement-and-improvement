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
    public class FlagRepository : IFlagRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Flag> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Flag(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Flag(), 1);
        }

        public MixERP.Net.Entities.Core.Flag Get(long flagId)
        {
            return new MixERP.Net.Entities.Core.Flag();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Flag> Get(long[] flagIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Flag(), 1);
        }

        public MixERP.Net.Entities.Core.Flag GetFirst()
        {
            return new MixERP.Net.Entities.Core.Flag();
        }

        public MixERP.Net.Entities.Core.Flag GetPrevious(long flagId)
        {
            return new MixERP.Net.Entities.Core.Flag();
        }

        public MixERP.Net.Entities.Core.Flag GetNext(long flagId)
        {
            return new MixERP.Net.Entities.Core.Flag();
        }

        public MixERP.Net.Entities.Core.Flag GetLast()
        {
            return new MixERP.Net.Entities.Core.Flag();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Flag> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Flag(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Flag> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Flag(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Flag> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Flag(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Flag> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Flag(), 1);
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

        public object AddOrEdit(dynamic flag, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic flag, long flagId)
        {
            if (flagId > 0)
            {
                return;
            }

            throw new ArgumentException("flagId is null.");
        }

        public object Add(dynamic flag)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> flags)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long flagId)
        {
            if (flagId > 0)
            {
                return;
            }

            throw new ArgumentException("flagId is null.");
        }


    }
}