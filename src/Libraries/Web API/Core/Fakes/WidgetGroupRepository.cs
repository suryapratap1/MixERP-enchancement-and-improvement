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
    public class WidgetGroupRepository : IWidgetGroupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetGroup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetGroup(), 1);
        }

        public MixERP.Net.Entities.Core.WidgetGroup Get(string widgetGroupName)
        {
            return new MixERP.Net.Entities.Core.WidgetGroup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> Get(string[] widgetGroupNames)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetGroup(), 1);
        }

        public MixERP.Net.Entities.Core.WidgetGroup GetFirst()
        {
            return new MixERP.Net.Entities.Core.WidgetGroup();
        }

        public MixERP.Net.Entities.Core.WidgetGroup GetPrevious(string widgetGroupName)
        {
            return new MixERP.Net.Entities.Core.WidgetGroup();
        }

        public MixERP.Net.Entities.Core.WidgetGroup GetNext(string widgetGroupName)
        {
            return new MixERP.Net.Entities.Core.WidgetGroup();
        }

        public MixERP.Net.Entities.Core.WidgetGroup GetLast()
        {
            return new MixERP.Net.Entities.Core.WidgetGroup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetGroup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetGroup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetGroup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetGroup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetGroup(), 1);
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

        public object AddOrEdit(dynamic widgetGroup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic widgetGroup, string widgetGroupName)
        {
            if (!string.IsNullOrWhiteSpace(widgetGroupName))
            {
                return;
            }

            throw new ArgumentException("widgetGroupName is null.");
        }

        public object Add(dynamic widgetGroup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> widgetGroups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string widgetGroupName)
        {
            if (!string.IsNullOrWhiteSpace(widgetGroupName))
            {
                return;
            }

            throw new ArgumentException("widgetGroupName is null.");
        }


    }
}