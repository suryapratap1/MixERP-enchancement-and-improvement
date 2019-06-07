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
    public class CardTypeRepository : ICardTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CardType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CardType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CardType(), 1);
        }

        public MixERP.Net.Entities.Core.CardType Get(int cardTypeId)
        {
            return new MixERP.Net.Entities.Core.CardType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CardType> Get(int[] cardTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CardType(), 1);
        }

        public MixERP.Net.Entities.Core.CardType GetFirst()
        {
            return new MixERP.Net.Entities.Core.CardType();
        }

        public MixERP.Net.Entities.Core.CardType GetPrevious(int cardTypeId)
        {
            return new MixERP.Net.Entities.Core.CardType();
        }

        public MixERP.Net.Entities.Core.CardType GetNext(int cardTypeId)
        {
            return new MixERP.Net.Entities.Core.CardType();
        }

        public MixERP.Net.Entities.Core.CardType GetLast()
        {
            return new MixERP.Net.Entities.Core.CardType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CardType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CardType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.CardType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CardType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.CardType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CardType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.CardType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.CardType(), 1);
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

        public object AddOrEdit(dynamic cardType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic cardType, int cardTypeId)
        {
            if (cardTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("cardTypeId is null.");
        }

        public object Add(dynamic cardType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> cardTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int cardTypeId)
        {
            if (cardTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("cardTypeId is null.");
        }


    }
}