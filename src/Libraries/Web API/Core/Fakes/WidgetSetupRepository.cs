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
    public class WidgetSetupRepository : IWidgetSetupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetSetup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetSetup(), 1);
        }

        public MixERP.Net.Entities.Core.WidgetSetup Get(int widgetSetupId)
        {
            return new MixERP.Net.Entities.Core.WidgetSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> Get(int[] widgetSetupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetSetup(), 1);
        }

        public MixERP.Net.Entities.Core.WidgetSetup GetFirst()
        {
            return new MixERP.Net.Entities.Core.WidgetSetup();
        }

        public MixERP.Net.Entities.Core.WidgetSetup GetPrevious(int widgetSetupId)
        {
            return new MixERP.Net.Entities.Core.WidgetSetup();
        }

        public MixERP.Net.Entities.Core.WidgetSetup GetNext(int widgetSetupId)
        {
            return new MixERP.Net.Entities.Core.WidgetSetup();
        }

        public MixERP.Net.Entities.Core.WidgetSetup GetLast()
        {
            return new MixERP.Net.Entities.Core.WidgetSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetSetup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetSetup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetSetup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.WidgetSetup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.WidgetSetup(), 1);
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

        public object AddOrEdit(dynamic widgetSetup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic widgetSetup, int widgetSetupId)
        {
            if (widgetSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("widgetSetupId is null.");
        }

        public object Add(dynamic widgetSetup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> widgetSetups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int widgetSetupId)
        {
            if (widgetSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("widgetSetupId is null.");
        }


    }
}