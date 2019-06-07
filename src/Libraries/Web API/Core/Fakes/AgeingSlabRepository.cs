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
    public class AgeingSlabRepository : IAgeingSlabRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AgeingSlab(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AgeingSlab(), 1);
        }

        public MixERP.Net.Entities.Core.AgeingSlab Get(int ageingSlabId)
        {
            return new MixERP.Net.Entities.Core.AgeingSlab();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> Get(int[] ageingSlabIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AgeingSlab(), 1);
        }

        public MixERP.Net.Entities.Core.AgeingSlab GetFirst()
        {
            return new MixERP.Net.Entities.Core.AgeingSlab();
        }

        public MixERP.Net.Entities.Core.AgeingSlab GetPrevious(int ageingSlabId)
        {
            return new MixERP.Net.Entities.Core.AgeingSlab();
        }

        public MixERP.Net.Entities.Core.AgeingSlab GetNext(int ageingSlabId)
        {
            return new MixERP.Net.Entities.Core.AgeingSlab();
        }

        public MixERP.Net.Entities.Core.AgeingSlab GetLast()
        {
            return new MixERP.Net.Entities.Core.AgeingSlab();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AgeingSlab(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AgeingSlab(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AgeingSlab(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.AgeingSlab> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.AgeingSlab(), 1);
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

        public object AddOrEdit(dynamic ageingSlab, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic ageingSlab, int ageingSlabId)
        {
            if (ageingSlabId > 0)
            {
                return;
            }

            throw new ArgumentException("ageingSlabId is null.");
        }

        public object Add(dynamic ageingSlab)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> ageingSlabs)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int ageingSlabId)
        {
            if (ageingSlabId > 0)
            {
                return;
            }

            throw new ArgumentException("ageingSlabId is null.");
        }


    }
}