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
    public class ShippingMailTypeRepository : IShippingMailTypeRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingMailType(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingMailType(), 1);
        }

        public MixERP.Net.Entities.Core.ShippingMailType Get(int shippingMailTypeId)
        {
            return new MixERP.Net.Entities.Core.ShippingMailType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> Get(int[] shippingMailTypeIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingMailType(), 1);
        }

        public MixERP.Net.Entities.Core.ShippingMailType GetFirst()
        {
            return new MixERP.Net.Entities.Core.ShippingMailType();
        }

        public MixERP.Net.Entities.Core.ShippingMailType GetPrevious(int shippingMailTypeId)
        {
            return new MixERP.Net.Entities.Core.ShippingMailType();
        }

        public MixERP.Net.Entities.Core.ShippingMailType GetNext(int shippingMailTypeId)
        {
            return new MixERP.Net.Entities.Core.ShippingMailType();
        }

        public MixERP.Net.Entities.Core.ShippingMailType GetLast()
        {
            return new MixERP.Net.Entities.Core.ShippingMailType();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingMailType(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingMailType(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingMailType(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingMailType> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingMailType(), 1);
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

        public object AddOrEdit(dynamic shippingMailType, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic shippingMailType, int shippingMailTypeId)
        {
            if (shippingMailTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("shippingMailTypeId is null.");
        }

        public object Add(dynamic shippingMailType)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> shippingMailTypes)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int shippingMailTypeId)
        {
            if (shippingMailTypeId > 0)
            {
                return;
            }

            throw new ArgumentException("shippingMailTypeId is null.");
        }


    }
}