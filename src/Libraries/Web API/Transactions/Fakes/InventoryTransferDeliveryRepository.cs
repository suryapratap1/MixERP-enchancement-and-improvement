// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class InventoryTransferDeliveryRepository : IInventoryTransferDeliveryRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), 1);
        }

        public MixERP.Net.Entities.Transactions.InventoryTransferDelivery Get(long inventoryTransferDeliveryId)
        {
            return new MixERP.Net.Entities.Transactions.InventoryTransferDelivery();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> Get([FromUri] long[] inventoryTransferDeliveryIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferDelivery(), 1);
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

        public object AddOrEdit(dynamic inventoryTransferDelivery, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic inventoryTransferDelivery, long inventoryTransferDeliveryId)
        {
            if (inventoryTransferDeliveryId > 0)
            {
                return;
            }

            throw new ArgumentException("inventoryTransferDeliveryId is null.");
        }

        public object Add(dynamic inventoryTransferDelivery)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> inventoryTransferDeliveries)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long inventoryTransferDeliveryId)
        {
            if (inventoryTransferDeliveryId > 0)
            {
                return;
            }

            throw new ArgumentException("inventoryTransferDeliveryId is null.");
        }


    }
}