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
    public class BonusSlabRepository : IBonusSlabRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlab(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlab(), 1);
        }

        public MixERP.Net.Entities.Core.BonusSlab Get(int bonusSlabId)
        {
            return new MixERP.Net.Entities.Core.BonusSlab();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> Get(int[] bonusSlabIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlab(), 1);
        }

        public MixERP.Net.Entities.Core.BonusSlab GetFirst()
        {
            return new MixERP.Net.Entities.Core.BonusSlab();
        }

        public MixERP.Net.Entities.Core.BonusSlab GetPrevious(int bonusSlabId)
        {
            return new MixERP.Net.Entities.Core.BonusSlab();
        }

        public MixERP.Net.Entities.Core.BonusSlab GetNext(int bonusSlabId)
        {
            return new MixERP.Net.Entities.Core.BonusSlab();
        }

        public MixERP.Net.Entities.Core.BonusSlab GetLast()
        {
            return new MixERP.Net.Entities.Core.BonusSlab();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlab(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlab(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlab(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlab> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlab(), 1);
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

        public object AddOrEdit(dynamic bonusSlab, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic bonusSlab, int bonusSlabId)
        {
            if (bonusSlabId > 0)
            {
                return;
            }

            throw new ArgumentException("bonusSlabId is null.");
        }

        public object Add(dynamic bonusSlab)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> bonusSlabs)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int bonusSlabId)
        {
            if (bonusSlabId > 0)
            {
                return;
            }

            throw new ArgumentException("bonusSlabId is null.");
        }


    }
}