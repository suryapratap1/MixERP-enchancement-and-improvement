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
    public class KanbanDetailRepository : IKanbanDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.KanbanDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.KanbanDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.KanbanDetail(), 1);
        }

        public MixERP.Net.Entities.Core.KanbanDetail Get(long kanbanDetailId)
        {
            return new MixERP.Net.Entities.Core.KanbanDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.KanbanDetail> Get(long[] kanbanDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.KanbanDetail(), 1);
        }

        public MixERP.Net.Entities.Core.KanbanDetail GetFirst()
        {
            return new MixERP.Net.Entities.Core.KanbanDetail();
        }

        public MixERP.Net.Entities.Core.KanbanDetail GetPrevious(long kanbanDetailId)
        {
            return new MixERP.Net.Entities.Core.KanbanDetail();
        }

        public MixERP.Net.Entities.Core.KanbanDetail GetNext(long kanbanDetailId)
        {
            return new MixERP.Net.Entities.Core.KanbanDetail();
        }

        public MixERP.Net.Entities.Core.KanbanDetail GetLast()
        {
            return new MixERP.Net.Entities.Core.KanbanDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Core.KanbanDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.KanbanDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.KanbanDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.KanbanDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.KanbanDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.KanbanDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.KanbanDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.KanbanDetail(), 1);
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

        public object AddOrEdit(dynamic kanbanDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic kanbanDetail, long kanbanDetailId)
        {
            if (kanbanDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("kanbanDetailId is null.");
        }

        public object Add(dynamic kanbanDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> kanbanDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long kanbanDetailId)
        {
            if (kanbanDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("kanbanDetailId is null.");
        }

        public IEnumerable<MixERP.Net.Entities.Core.KanbanDetail> Get(long[] kanbanIds, object[] resourceIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.KanbanDetail(), 1);
        }

    }
}