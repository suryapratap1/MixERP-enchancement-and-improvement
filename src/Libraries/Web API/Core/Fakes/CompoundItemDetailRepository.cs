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
    public class CompoundItemDetailRepository : ICompoundItemDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItemDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItemDetail(), 1);
        }

        public MixERP.Net.Entities.Core.CompoundItemDetail Get(int compoundItemDetailId)
        {
            return new MixERP.Net.Entities.Core.CompoundItemDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> Get(int[] compoundItemDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItemDetail(), 1);
        }

        public MixERP.Net.Entities.Core.CompoundItemDetail GetFirst()
        {
            return new MixERP.Net.Entities.Core.CompoundItemDetail();
        }

        public MixERP.Net.Entities.Core.CompoundItemDetail GetPrevious(int compoundItemDetailId)
        {
            return new MixERP.Net.Entities.Core.CompoundItemDetail();
        }

        public MixERP.Net.Entities.Core.CompoundItemDetail GetNext(int compoundItemDetailId)
        {
            return new MixERP.Net.Entities.Core.CompoundItemDetail();
        }

        public MixERP.Net.Entities.Core.CompoundItemDetail GetLast()
        {
            return new MixERP.Net.Entities.Core.CompoundItemDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItemDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItemDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItemDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CompoundItemDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CompoundItemDetail(), 1);
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

        public object AddOrEdit(dynamic compoundItemDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic compoundItemDetail, int compoundItemDetailId)
        {
            if (compoundItemDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("compoundItemDetailId is null.");
        }

        public object Add(dynamic compoundItemDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> compoundItemDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int compoundItemDetailId)
        {
            if (compoundItemDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("compoundItemDetailId is null.");
        }


    }
}