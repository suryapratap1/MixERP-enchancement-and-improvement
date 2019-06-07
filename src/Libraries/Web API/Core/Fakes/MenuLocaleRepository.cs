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
    public class MenuLocaleRepository : IMenuLocaleRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MenuLocale(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MenuLocale(), 1);
        }

        public MixERP.Net.Entities.Core.MenuLocale Get(int menuLocaleId)
        {
            return new MixERP.Net.Entities.Core.MenuLocale();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MenuLocale> Get(int[] menuLocaleIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MenuLocale(), 1);
        }

        public MixERP.Net.Entities.Core.MenuLocale GetFirst()
        {
            return new MixERP.Net.Entities.Core.MenuLocale();
        }

        public MixERP.Net.Entities.Core.MenuLocale GetPrevious(int menuLocaleId)
        {
            return new MixERP.Net.Entities.Core.MenuLocale();
        }

        public MixERP.Net.Entities.Core.MenuLocale GetNext(int menuLocaleId)
        {
            return new MixERP.Net.Entities.Core.MenuLocale();
        }

        public MixERP.Net.Entities.Core.MenuLocale GetLast()
        {
            return new MixERP.Net.Entities.Core.MenuLocale();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MenuLocale(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MenuLocale(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MenuLocale(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.MenuLocale> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.MenuLocale(), 1);
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

        public object AddOrEdit(dynamic menuLocale, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic menuLocale, int menuLocaleId)
        {
            if (menuLocaleId > 0)
            {
                return;
            }

            throw new ArgumentException("menuLocaleId is null.");
        }

        public object Add(dynamic menuLocale)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> menuLocales)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int menuLocaleId)
        {
            if (menuLocaleId > 0)
            {
                return;
            }

            throw new ArgumentException("menuLocaleId is null.");
        }


    }
}