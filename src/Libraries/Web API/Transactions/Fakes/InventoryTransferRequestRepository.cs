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
    public class InventoryTransferRequestRepository : IInventoryTransferRequestRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequest(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequest(), 1);
        }

        public MixERP.Net.Entities.Transactions.InventoryTransferRequest Get(long inventoryTransferRequestId)
        {
            return new MixERP.Net.Entities.Transactions.InventoryTransferRequest();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> Get([FromUri] long[] inventoryTransferRequestIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequest(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequest(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequest(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequest(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequest(), 1);
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

        public object AddOrEdit(dynamic inventoryTransferRequest, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic inventoryTransferRequest, long inventoryTransferRequestId)
        {
            if (inventoryTransferRequestId > 0)
            {
                return;
            }

            throw new ArgumentException("inventoryTransferRequestId is null.");
        }

        public object Add(dynamic inventoryTransferRequest)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> inventoryTransferRequests)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long inventoryTransferRequestId)
        {
            if (inventoryTransferRequestId > 0)
            {
                return;
            }

            throw new ArgumentException("inventoryTransferRequestId is null.");
        }


    }
}