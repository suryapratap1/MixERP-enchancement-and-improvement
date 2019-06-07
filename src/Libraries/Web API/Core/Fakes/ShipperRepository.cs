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
    public class ShipperRepository : IShipperRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Shipper> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Shipper(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Shipper(), 1);
        }

        public MixERP.Net.Entities.Core.Shipper Get(int shipperId)
        {
            return new MixERP.Net.Entities.Core.Shipper();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Shipper> Get(int[] shipperIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Shipper(), 1);
        }

        public MixERP.Net.Entities.Core.Shipper GetFirst()
        {
            return new MixERP.Net.Entities.Core.Shipper();
        }

        public MixERP.Net.Entities.Core.Shipper GetPrevious(int shipperId)
        {
            return new MixERP.Net.Entities.Core.Shipper();
        }

        public MixERP.Net.Entities.Core.Shipper GetNext(int shipperId)
        {
            return new MixERP.Net.Entities.Core.Shipper();
        }

        public MixERP.Net.Entities.Core.Shipper GetLast()
        {
            return new MixERP.Net.Entities.Core.Shipper();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Shipper> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Shipper(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Core.Shipper> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Shipper(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Core.Shipper> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Shipper(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Core.Shipper> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Core.Shipper(), 1);
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

        public object AddOrEdit(dynamic shipper, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic shipper, int shipperId)
        {
            if (shipperId > 0)
            {
                return;
            }

            throw new ArgumentException("shipperId is null.");
        }

        public object Add(dynamic shipper)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> shippers)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int shipperId)
        {
            if (shipperId > 0)
            {
                return;
            }

            throw new ArgumentException("shipperId is null.");
        }


    }
}