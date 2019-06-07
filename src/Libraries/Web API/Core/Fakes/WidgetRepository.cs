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
    public class WidgetRepository : IWidgetRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Widget> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Widget(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Widget(), 1);
        }

        public MixERP.Net.Entities.Core.Widget Get(string widgetName)
        {
            return new MixERP.Net.Entities.Core.Widget();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Widget> Get(string[] widgetNames)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Widget(), 1);
        }

        public MixERP.Net.Entities.Core.Widget GetFirst()
        {
            return new MixERP.Net.Entities.Core.Widget();
        }

        public MixERP.Net.Entities.Core.Widget GetPrevious(string widgetName)
        {
            return new MixERP.Net.Entities.Core.Widget();
        }

        public MixERP.Net.Entities.Core.Widget GetNext(string widgetName)
        {
            return new MixERP.Net.Entities.Core.Widget();
        }

        public MixERP.Net.Entities.Core.Widget GetLast()
        {
            return new MixERP.Net.Entities.Core.Widget();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Widget> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Widget(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Widget> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Widget(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Widget> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Widget(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Widget> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Widget(), 1);
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

        public object AddOrEdit(dynamic widget, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic widget, string widgetName)
        {
            if (!string.IsNullOrWhiteSpace(widgetName))
            {
                return;
            }

            throw new ArgumentException("widgetName is null.");
        }

        public object Add(dynamic widget)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> widgets)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(string widgetName)
        {
            if (!string.IsNullOrWhiteSpace(widgetName))
            {
                return;
            }

            throw new ArgumentException("widgetName is null.");
        }


    }
}