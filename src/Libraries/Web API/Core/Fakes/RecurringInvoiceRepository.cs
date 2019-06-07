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
    public class RecurringInvoiceRepository : IRecurringInvoiceRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoice(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoice(), 1);
        }

        public MixERP.Net.Entities.Core.RecurringInvoice Get(int recurringInvoiceId)
        {
            return new MixERP.Net.Entities.Core.RecurringInvoice();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> Get(int[] recurringInvoiceIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoice(), 1);
        }

        public MixERP.Net.Entities.Core.RecurringInvoice GetFirst()
        {
            return new MixERP.Net.Entities.Core.RecurringInvoice();
        }

        public MixERP.Net.Entities.Core.RecurringInvoice GetPrevious(int recurringInvoiceId)
        {
            return new MixERP.Net.Entities.Core.RecurringInvoice();
        }

        public MixERP.Net.Entities.Core.RecurringInvoice GetNext(int recurringInvoiceId)
        {
            return new MixERP.Net.Entities.Core.RecurringInvoice();
        }

        public MixERP.Net.Entities.Core.RecurringInvoice GetLast()
        {
            return new MixERP.Net.Entities.Core.RecurringInvoice();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoice(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoice(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoice(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.RecurringInvoice> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.RecurringInvoice(), 1);
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

        public object AddOrEdit(dynamic recurringInvoice, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic recurringInvoice, int recurringInvoiceId)
        {
            if (recurringInvoiceId > 0)
            {
                return;
            }

            throw new ArgumentException("recurringInvoiceId is null.");
        }

        public object Add(dynamic recurringInvoice)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> recurringInvoices)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int recurringInvoiceId)
        {
            if (recurringInvoiceId > 0)
            {
                return;
            }

            throw new ArgumentException("recurringInvoiceId is null.");
        }


    }
}