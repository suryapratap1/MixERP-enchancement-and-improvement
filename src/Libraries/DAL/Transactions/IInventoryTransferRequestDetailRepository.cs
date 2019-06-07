// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IInventoryTransferRequestDetailRepository
    {
        /// <summary>
        /// Counts the number of InventoryTransferRequestDetail in IInventoryTransferRequestDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IInventoryTransferRequestDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of InventoryTransferRequestDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of InventoryTransferRequestDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetAll();

        /// <summary>
        /// Returns all instances of InventoryTransferRequestDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of InventoryTransferRequestDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the InventoryTransferRequestDetail against inventoryTransferRequestDetailId. 
        /// </summary>
        /// <param name="inventoryTransferRequestDetailId">The column "inventory_transfer_request_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of InventoryTransferRequestDetail.</returns>
        MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail Get(long inventoryTransferRequestDetailId);

        /// <summary>
        /// Returns multiple instances of the InventoryTransferRequestDetail against inventoryTransferRequestDetailIds. 
        /// </summary>
        /// <param name="inventoryTransferRequestDetailIds">Array of column "inventory_transfer_request_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of InventoryTransferRequestDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> Get(long[] inventoryTransferRequestDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IInventoryTransferRequestDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for InventoryTransferRequestDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding InventoryTransferRequestDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for InventoryTransferRequestDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of InventoryTransferRequestDetail class to IInventoryTransferRequestDetailRepository.
        /// </summary>
        /// <param name="inventoryTransferRequestDetail">The instance of InventoryTransferRequestDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic inventoryTransferRequestDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of InventoryTransferRequestDetail class to IInventoryTransferRequestDetailRepository.
        /// </summary>
        /// <param name="inventoryTransferRequestDetail">The instance of InventoryTransferRequestDetail class to insert.</param>
        object Add(dynamic inventoryTransferRequestDetail);

        /// <summary>
        /// Inserts or updates multiple instances of InventoryTransferRequestDetail class to IInventoryTransferRequestDetailRepository.;
        /// </summary>
        /// <param name="inventoryTransferRequestDetails">List of InventoryTransferRequestDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> inventoryTransferRequestDetails);


        /// <summary>
        /// Updates IInventoryTransferRequestDetailRepository with an instance of InventoryTransferRequestDetail class against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferRequestDetail">The instance of InventoryTransferRequestDetail class to update.</param>
        /// <param name="inventoryTransferRequestDetailId">The value of the column "inventory_transfer_request_detail_id" which will be updated.</param>
        void Update(dynamic inventoryTransferRequestDetail, long inventoryTransferRequestDetailId);

        /// <summary>
        /// Deletes InventoryTransferRequestDetail from  IInventoryTransferRequestDetailRepository against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferRequestDetailId">The value of the column "inventory_transfer_request_detail_id" which will be deleted.</param>
        void Delete(long inventoryTransferRequestDetailId);

        /// <summary>
        /// Produces a paginated result of 10 InventoryTransferRequestDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of InventoryTransferRequestDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 InventoryTransferRequestDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of InventoryTransferRequestDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IInventoryTransferRequestDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of InventoryTransferRequestDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IInventoryTransferRequestDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of InventoryTransferRequestDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IInventoryTransferRequestDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of InventoryTransferRequestDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IInventoryTransferRequestDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of InventoryTransferRequestDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetFiltered(long pageNumber, string filterName);



    }
}