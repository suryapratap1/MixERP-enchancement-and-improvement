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
    public class CashFlowSetupRepository : ICashFlowSetupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowSetup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowSetup(), 1);
        }

        public MixERP.Net.Entities.Core.CashFlowSetup Get(int cashFlowSetupId)
        {
            return new MixERP.Net.Entities.Core.CashFlowSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> Get(int[] cashFlowSetupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowSetup(), 1);
        }

        public MixERP.Net.Entities.Core.CashFlowSetup GetFirst()
        {
            return new MixERP.Net.Entities.Core.CashFlowSetup();
        }

        public MixERP.Net.Entities.Core.CashFlowSetup GetPrevious(int cashFlowSetupId)
        {
            return new MixERP.Net.Entities.Core.CashFlowSetup();
        }

        public MixERP.Net.Entities.Core.CashFlowSetup GetNext(int cashFlowSetupId)
        {
            return new MixERP.Net.Entities.Core.CashFlowSetup();
        }

        public MixERP.Net.Entities.Core.CashFlowSetup GetLast()
        {
            return new MixERP.Net.Entities.Core.CashFlowSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowSetup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowSetup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowSetup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowSetup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowSetup(), 1);
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

        public object AddOrEdit(dynamic cashFlowSetup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic cashFlowSetup, int cashFlowSetupId)
        {
            if (cashFlowSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("cashFlowSetupId is null.");
        }

        public object Add(dynamic cashFlowSetup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> cashFlowSetups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int cashFlowSetupId)
        {
            if (cashFlowSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("cashFlowSetupId is null.");
        }


    }
}