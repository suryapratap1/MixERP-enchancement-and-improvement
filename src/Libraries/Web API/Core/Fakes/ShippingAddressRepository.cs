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
    public class ShippingAddressRepository : IShippingAddressRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingAddress(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingAddress(), 1);
        }

        public MixERP.Net.Entities.Core.ShippingAddress Get(long shippingAddressId)
        {
            return new MixERP.Net.Entities.Core.ShippingAddress();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> Get(long[] shippingAddressIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingAddress(), 1);
        }

        public MixERP.Net.Entities.Core.ShippingAddress GetFirst()
        {
            return new MixERP.Net.Entities.Core.ShippingAddress();
        }

        public MixERP.Net.Entities.Core.ShippingAddress GetPrevious(long shippingAddressId)
        {
            return new MixERP.Net.Entities.Core.ShippingAddress();
        }

        public MixERP.Net.Entities.Core.ShippingAddress GetNext(long shippingAddressId)
        {
            return new MixERP.Net.Entities.Core.ShippingAddress();
        }

        public MixERP.Net.Entities.Core.ShippingAddress GetLast()
        {
            return new MixERP.Net.Entities.Core.ShippingAddress();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingAddress(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingAddress(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingAddress(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.ShippingAddress> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.ShippingAddress(), 1);
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

        public object AddOrEdit(dynamic shippingAddress, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic shippingAddress, long shippingAddressId)
        {
            if (shippingAddressId > 0)
            {
                return;
            }

            throw new ArgumentException("shippingAddressId is null.");
        }

        public object Add(dynamic shippingAddress)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> shippingAddresses)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long shippingAddressId)
        {
            if (shippingAddressId > 0)
            {
                return;
            }

            throw new ArgumentException("shippingAddressId is null.");
        }


    }
}