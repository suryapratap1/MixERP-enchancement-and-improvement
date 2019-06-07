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
    public class CashFlowHeadingRepository : ICashFlowHeadingRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowHeading(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowHeading(), 1);
        }

        public MixERP.Net.Entities.Core.CashFlowHeading Get(int cashFlowHeadingId)
        {
            return new MixERP.Net.Entities.Core.CashFlowHeading();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> Get(int[] cashFlowHeadingIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowHeading(), 1);
        }

        public MixERP.Net.Entities.Core.CashFlowHeading GetFirst()
        {
            return new MixERP.Net.Entities.Core.CashFlowHeading();
        }

        public MixERP.Net.Entities.Core.CashFlowHeading GetPrevious(int cashFlowHeadingId)
        {
            return new MixERP.Net.Entities.Core.CashFlowHeading();
        }

        public MixERP.Net.Entities.Core.CashFlowHeading GetNext(int cashFlowHeadingId)
        {
            return new MixERP.Net.Entities.Core.CashFlowHeading();
        }

        public MixERP.Net.Entities.Core.CashFlowHeading GetLast()
        {
            return new MixERP.Net.Entities.Core.CashFlowHeading();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowHeading(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowHeading(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowHeading(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CashFlowHeading> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CashFlowHeading(), 1);
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

        public object AddOrEdit(dynamic cashFlowHeading, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic cashFlowHeading, int cashFlowHeadingId)
        {
            if (cashFlowHeadingId > 0)
            {
                return;
            }

            throw new ArgumentException("cashFlowHeadingId is null.");
        }

        public object Add(dynamic cashFlowHeading)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> cashFlowHeadings)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int cashFlowHeadingId)
        {
            if (cashFlowHeadingId > 0)
            {
                return;
            }

            throw new ArgumentException("cashFlowHeadingId is null.");
        }


    }
}