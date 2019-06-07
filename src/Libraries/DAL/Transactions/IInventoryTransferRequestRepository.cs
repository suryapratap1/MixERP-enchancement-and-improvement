// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IInventoryTransferRequestRepository
    {
        /// <summary>
        /// Counts the number of InventoryTransferRequest in IInventoryTransferRequestRepository.
        /// </summary>
        /// <returns>Returns the count of IInventoryTransferRequestRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of InventoryTransferRequest. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of InventoryTransferRequest.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetAll();

        /// <summary>
        /// Returns all instances of InventoryTransferRequest to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of InventoryTransferRequest.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the InventoryTransferRequest against inventoryTransferRequestId. 
        /// </summary>
        /// <param name="inventoryTransferRequestId">The column "inventory_transfer_request_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of InventoryTransferRequest.</returns>
        MixERP.Net.Entities.Transactions.InventoryTransferRequest Get(long inventoryTransferRequestId);

        /// <summary>
        /// Returns multiple instances of the InventoryTransferRequest against inventoryTransferRequestIds. 
        /// </summary>
        /// <param name="inventoryTransferRequestIds">Array of column "inventory_transfer_request_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of InventoryTransferRequest.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> Get(long[] inventoryTransferRequestIds);

        /// <summary>
        /// Custom fields are user defined form elements for IInventoryTransferRequestRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for InventoryTransferRequest.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding InventoryTransferRequest.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for InventoryTransferRequest.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of InventoryTransferRequest class to IInventoryTransferRequestRepository.
        /// </summary>
        /// <param name="inventoryTransferRequest">The instance of InventoryTransferRequest class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic inventoryTransferRequest, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of InventoryTransferRequest class to IInventoryTransferRequestRepository.
        /// </summary>
        /// <param name="inventoryTransferRequest">The instance of InventoryTransferRequest class to insert.</param>
        object Add(dynamic inventoryTransferRequest);

        /// <summary>
        /// Inserts or updates multiple instances of InventoryTransferRequest class to IInventoryTransferRequestRepository.;
        /// </summary>
        /// <param name="inventoryTransferRequests">List of InventoryTransferRequest class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> inventoryTransferRequests);


        /// <summary>
        /// Updates IInventoryTransferRequestRepository with an instance of InventoryTransferRequest class against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferRequest">The instance of InventoryTransferRequest class to update.</param>
        /// <param name="inventoryTransferRequestId">The value of the column "inventory_transfer_request_id" which will be updated.</param>
        void Update(dynamic inventoryTransferRequest, long inventoryTransferRequestId);

        /// <summary>
        /// Deletes InventoryTransferRequest from  IInventoryTransferRequestRepository against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferRequestId">The value of the column "inventory_transfer_request_id" which will be deleted.</param>
        void Delete(long inventoryTransferRequestId);

        /// <summary>
        /// Produces a paginated result of 10 InventoryTransferRequest classes.
        /// </summary>
        /// <returns>Returns the first page of collection of InventoryTransferRequest class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 InventoryTransferRequest classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of InventoryTransferRequest class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IInventoryTransferRequestRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of InventoryTransferRequest class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IInventoryTransferRequestRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of InventoryTransferRequest class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IInventoryTransferRequestRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of InventoryTransferRequest class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IInventoryTransferRequestRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of InventoryTransferRequest class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequest> GetFiltered(long pageNumber, string filterName);



    }
}