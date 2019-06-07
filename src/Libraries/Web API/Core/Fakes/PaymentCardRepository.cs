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
    public class PaymentCardRepository : IPaymentCardRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentCard(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentCard(), 1);
        }

        public MixERP.Net.Entities.Core.PaymentCard Get(int paymentCardId)
        {
            return new MixERP.Net.Entities.Core.PaymentCard();
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentCard> Get(int[] paymentCardIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentCard(), 1);
        }

        public MixERP.Net.Entities.Core.PaymentCard GetFirst()
        {
            return new MixERP.Net.Entities.Core.PaymentCard();
        }

        public MixERP.Net.Entities.Core.PaymentCard GetPrevious(int paymentCardId)
        {
            return new MixERP.Net.Entities.Core.PaymentCard();
        }

        public MixERP.Net.Entities.Core.PaymentCard GetNext(int paymentCardId)
        {
            return new MixERP.Net.Entities.Core.PaymentCard();
        }

        public MixERP.Net.Entities.Core.PaymentCard GetLast()
        {
            return new MixERP.Net.Entities.Core.PaymentCard();
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentCard(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentCard(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentCard(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.PaymentCard> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.PaymentCard(), 1);
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

        public object AddOrEdit(dynamic paymentCard, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic paymentCard, int paymentCardId)
        {
            if (paymentCardId > 0)
            {
                return;
            }

            throw new ArgumentException("paymentCardId is null.");
        }

        public object Add(dynamic paymentCard)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> paymentCards)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int paymentCardId)
        {
            if (paymentCardId > 0)
            {
                return;
            }

            throw new ArgumentException("paymentCardId is null.");
        }


    }
}