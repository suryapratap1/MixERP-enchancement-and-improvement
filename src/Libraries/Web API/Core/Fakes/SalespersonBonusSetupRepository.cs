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
    public class SalespersonBonusSetupRepository : ISalespersonBonusSetupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalespersonBonusSetup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalespersonBonusSetup(), 1);
        }

        public MixERP.Net.Entities.Core.SalespersonBonusSetup Get(int salespersonBonusSetupId)
        {
            return new MixERP.Net.Entities.Core.SalespersonBonusSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> Get(int[] salespersonBonusSetupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalespersonBonusSetup(), 1);
        }

        public MixERP.Net.Entities.Core.SalespersonBonusSetup GetFirst()
        {
            return new MixERP.Net.Entities.Core.SalespersonBonusSetup();
        }

        public MixERP.Net.Entities.Core.SalespersonBonusSetup GetPrevious(int salespersonBonusSetupId)
        {
            return new MixERP.Net.Entities.Core.SalespersonBonusSetup();
        }

        public MixERP.Net.Entities.Core.SalespersonBonusSetup GetNext(int salespersonBonusSetupId)
        {
            return new MixERP.Net.Entities.Core.SalespersonBonusSetup();
        }

        public MixERP.Net.Entities.Core.SalespersonBonusSetup GetLast()
        {
            return new MixERP.Net.Entities.Core.SalespersonBonusSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalespersonBonusSetup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalespersonBonusSetup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalespersonBonusSetup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.SalespersonBonusSetup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.SalespersonBonusSetup(), 1);
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

        public object AddOrEdit(dynamic salespersonBonusSetup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic salespersonBonusSetup, int salespersonBonusSetupId)
        {
            if (salespersonBonusSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("salespersonBonusSetupId is null.");
        }

        public object Add(dynamic salespersonBonusSetup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> salespersonBonusSetups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int salespersonBonusSetupId)
        {
            if (salespersonBonusSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("salespersonBonusSetupId is null.");
        }


    }
}