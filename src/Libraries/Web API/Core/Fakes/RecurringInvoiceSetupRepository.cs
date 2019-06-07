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
    public class RecurringInvoiceSetupRepository : IRecurringInvoiceSetupRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoiceSetup(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoiceSetup(), 1);
        }

        public MixERP.Net.Entities.Core.RecurringInvoiceSetup Get(int recurringInvoiceSetupId)
        {
            return new MixERP.Net.Entities.Core.RecurringInvoiceSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> Get(int[] recurringInvoiceSetupIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoiceSetup(), 1);
        }

        public MixERP.Net.Entities.Core.RecurringInvoiceSetup GetFirst()
        {
            return new MixERP.Net.Entities.Core.RecurringInvoiceSetup();
        }

        public MixERP.Net.Entities.Core.RecurringInvoiceSetup GetPrevious(int recurringInvoiceSetupId)
        {
            return new MixERP.Net.Entities.Core.RecurringInvoiceSetup();
        }

        public MixERP.Net.Entities.Core.RecurringInvoiceSetup GetNext(int recurringInvoiceSetupId)
        {
            return new MixERP.Net.Entities.Core.RecurringInvoiceSetup();
        }

        public MixERP.Net.Entities.Core.RecurringInvoiceSetup GetLast()
        {
            return new MixERP.Net.Entities.Core.RecurringInvoiceSetup();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoiceSetup(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoiceSetup(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoiceSetup(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoiceSetup> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoiceSetup(), 1);
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

        public object AddOrEdit(dynamic recurringInvoiceSetup, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic recurringInvoiceSetup, int recurringInvoiceSetupId)
        {
            if (recurringInvoiceSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("recurringInvoiceSetupId is null.");
        }

        public object Add(dynamic recurringInvoiceSetup)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> recurringInvoiceSetups)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int recurringInvoiceSetupId)
        {
            if (recurringInvoiceSetupId > 0)
            {
                return;
            }

            throw new ArgumentException("recurringInvoiceSetupId is null.");
        }


    }
}