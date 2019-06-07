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
    public class MenuRepository : IMenuRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Menu> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Menu(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Menu(), 1);
        }

        public MixERP.Net.Entities.Core.Menu Get(int menuId)
        {
            return new MixERP.Net.Entities.Core.Menu();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Menu> Get(int[] menuIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Menu(), 1);
        }

        public MixERP.Net.Entities.Core.Menu GetFirst()
        {
            return new MixERP.Net.Entities.Core.Menu();
        }

        public MixERP.Net.Entities.Core.Menu GetPrevious(int menuId)
        {
            return new MixERP.Net.Entities.Core.Menu();
        }

        public MixERP.Net.Entities.Core.Menu GetNext(int menuId)
        {
            return new MixERP.Net.Entities.Core.Menu();
        }

        public MixERP.Net.Entities.Core.Menu GetLast()
        {
            return new MixERP.Net.Entities.Core.Menu();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Menu> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Menu(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Menu> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Menu(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Menu> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Menu(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Menu> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Menu(), 1);
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

        public object AddOrEdit(dynamic menu, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic menu, int menuId)
        {
            if (menuId > 0)
            {
                return;
            }

            throw new ArgumentException("menuId is null.");
        }

        public object Add(dynamic menu)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> menus)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int menuId)
        {
            if (menuId > 0)
            {
                return;
            }

            throw new ArgumentException("menuId is null.");
        }


    }
}