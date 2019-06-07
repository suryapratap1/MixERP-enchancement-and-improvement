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
    public class PaymentTermRepository : IPaymentTermRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentTerm(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentTerm(), 1);
        }

        public MixERP.Net.Entities.Core.PaymentTerm Get(int paymentTermId)
        {
            return new MixERP.Net.Entities.Core.PaymentTerm();
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> Get(int[] paymentTermIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentTerm(), 1);
        }

        public MixERP.Net.Entities.Core.PaymentTerm GetFirst()
        {
            return new MixERP.Net.Entities.Core.PaymentTerm();
        }

        public MixERP.Net.Entities.Core.PaymentTerm GetPrevious(int paymentTermId)
        {
            return new MixERP.Net.Entities.Core.PaymentTerm();
        }

        public MixERP.Net.Entities.Core.PaymentTerm GetNext(int paymentTermId)
        {
            return new MixERP.Net.Entities.Core.PaymentTerm();
        }

        public MixERP.Net.Entities.Core.PaymentTerm GetLast()
        {
            return new MixERP.Net.Entities.Core.PaymentTerm();
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentTerm(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentTerm(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentTerm(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentTerm> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentTerm(), 1);
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

        public object AddOrEdit(dynamic paymentTerm, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic paymentTerm, int paymentTermId)
        {
            if (paymentTermId > 0)
            {
                return;
            }

            throw new ArgumentException("paymentTermId is null.");
        }

        public object Add(dynamic paymentTerm)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> paymentTerms)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int paymentTermId)
        {
            if (paymentTermId > 0)
            {
                return;
            }

            throw new ArgumentException("paymentTermId is null.");
        }


    }
}