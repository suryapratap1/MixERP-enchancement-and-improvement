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
    public class ConfigRepository : IConfigRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Config> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Config(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Config(), 1);
        }

        public MixERP.Net.Entities.Core.Config Get(int configId)
        {
            return new MixERP.Net.Entities.Core.Config();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Config> Get(int[] configIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Config(), 1);
        }

        public MixERP.Net.Entities.Core.Config GetFirst()
        {
            return new MixERP.Net.Entities.Core.Config();
        }

        public MixERP.Net.Entities.Core.Config GetPrevious(int configId)
        {
            return new MixERP.Net.Entities.Core.Config();
        }

        public MixERP.Net.Entities.Core.Config GetNext(int configId)
        {
            return new MixERP.Net.Entities.Core.Config();
        }

        public MixERP.Net.Entities.Core.Config GetLast()
        {
            return new MixERP.Net.Entities.Core.Config();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Config> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Config(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Config> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Config(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Config> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Config(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Config> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Config(), 1);
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

        public object AddOrEdit(dynamic config, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic config, int configId)
        {
            if (configId > 0)
            {
                return;
            }

            throw new ArgumentException("configId is null.");
        }

        public object Add(dynamic config)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> configs)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int configId)
        {
            if (configId > 0)
            {
                return;
            }

            throw new ArgumentException("configId is null.");
        }


    }
}