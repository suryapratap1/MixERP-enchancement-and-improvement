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
    public class BonusSlabDetailRepository : IBonusSlabDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlabDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlabDetail(), 1);
        }

        public MixERP.Net.Entities.Core.BonusSlabDetail Get(int bonusSlabDetailId)
        {
            return new MixERP.Net.Entities.Core.BonusSlabDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> Get(int[] bonusSlabDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlabDetail(), 1);
        }

        public MixERP.Net.Entities.Core.BonusSlabDetail GetFirst()
        {
            return new MixERP.Net.Entities.Core.BonusSlabDetail();
        }

        public MixERP.Net.Entities.Core.BonusSlabDetail GetPrevious(int bonusSlabDetailId)
        {
            return new MixERP.Net.Entities.Core.BonusSlabDetail();
        }

        public MixERP.Net.Entities.Core.BonusSlabDetail GetNext(int bonusSlabDetailId)
        {
            return new MixERP.Net.Entities.Core.BonusSlabDetail();
        }

        public MixERP.Net.Entities.Core.BonusSlabDetail GetLast()
        {
            return new MixERP.Net.Entities.Core.BonusSlabDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlabDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlabDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlabDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.BonusSlabDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.BonusSlabDetail(), 1);
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

        public object AddOrEdit(dynamic bonusSlabDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic bonusSlabDetail, int bonusSlabDetailId)
        {
            if (bonusSlabDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("bonusSlabDetailId is null.");
        }

        public object Add(dynamic bonusSlabDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> bonusSlabDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int bonusSlabDetailId)
        {
            if (bonusSlabDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("bonusSlabDetailId is null.");
        }


    }
}