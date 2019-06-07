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
    public class KanbanRepository : IKanbanRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Kanban> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Kanban(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Kanban(), 1);
        }

        public MixERP.Net.Entities.Core.Kanban Get(long kanbanId)
        {
            return new MixERP.Net.Entities.Core.Kanban();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Kanban> Get(long[] kanbanIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Kanban(), 1);
        }

        public MixERP.Net.Entities.Core.Kanban GetFirst()
        {
            return new MixERP.Net.Entities.Core.Kanban();
        }

        public MixERP.Net.Entities.Core.Kanban GetPrevious(long kanbanId)
        {
            return new MixERP.Net.Entities.Core.Kanban();
        }

        public MixERP.Net.Entities.Core.Kanban GetNext(long kanbanId)
        {
            return new MixERP.Net.Entities.Core.Kanban();
        }

        public MixERP.Net.Entities.Core.Kanban GetLast()
        {
            return new MixERP.Net.Entities.Core.Kanban();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Kanban> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Kanban(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Kanban> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Kanban(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Kanban> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Kanban(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Kanban> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Kanban(), 1);
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

        public object AddOrEdit(dynamic kanban, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic kanban, long kanbanId)
        {
            if (kanbanId > 0)
            {
                return;
            }

            throw new ArgumentException("kanbanId is null.");
        }

        public object Add(dynamic kanban)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> kanbans)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long kanbanId)
        {
            if (kanbanId > 0)
            {
                return;
            }

            throw new ArgumentException("kanbanId is null.");
        }


    }
}