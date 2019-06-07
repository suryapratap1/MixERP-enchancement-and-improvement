// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IInventoryTransferDeliveryDetailRepository
    {
        /// <summary>
        /// Counts the number of InventoryTransferDeliveryDetail in IInventoryTransferDeliveryDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IInventoryTransferDeliveryDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of InventoryTransferDeliveryDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of InventoryTransferDeliveryDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDeliveryDetail> GetAll();

        /// <summary>
        /// Returns all instances of InventoryTransferDeliveryDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of InventoryTransferDeliveryDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the InventoryTransferDeliveryDetail against inventoryTransferDeliveryDetailId. 
        /// </summary>
        /// <param name="inventoryTransferDeliveryDetailId">The column "inventory_transfer_delivery_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of InventoryTransferDeliveryDetail.</returns>
        MixERP.Net.Entities.Transactions.InventoryTransferDeliveryDetail Get(long inventoryTransferDeliveryDetailId);

        /// <summary>
        /// Returns multiple instances of the InventoryTransferDeliveryDetail against inventoryTransferDeliveryDetailIds. 
        /// </summary>
        /// <param name="inventoryTransferDeliveryDetailIds">Array of column "inventory_transfer_delivery_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of InventoryTransferDeliveryDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDeliveryDetail> Get(long[] inventoryTransferDeliveryDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IInventoryTransferDeliveryDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for InventoryTransferDeliveryDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding InventoryTransferDeliveryDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for InventoryTransferDeliveryDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of InventoryTransferDeliveryDetail class to IInventoryTransferDeliveryDetailRepository.
        /// </summary>
        /// <param name="inventoryTransferDeliveryDetail">The instance of InventoryTransferDeliveryDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic inventoryTransferDeliveryDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of InventoryTransferDeliveryDetail class to IInventoryTransferDeliveryDetailRepository.
        /// </summary>
        /// <param name="inventoryTransferDeliveryDetail">The instance of InventoryTransferDeliveryDetail class to insert.</param>
        object Add(dynamic inventoryTransferDeliveryDetail);

        /// <summary>
        /// Inserts or updates multiple instances of InventoryTransferDeliveryDetail class to IInventoryTransferDeliveryDetailRepository.;
        /// </summary>
        /// <param name="inventoryTransferDeliveryDetails">List of InventoryTransferDeliveryDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> inventoryTransferDeliveryDetails);


        /// <summary>
        /// Updates IInventoryTransferDeliveryDetailRepository with an instance of InventoryTransferDeliveryDetail class against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferDeliveryDetail">The instance of InventoryTransferDeliveryDetail class to update.</param>
        /// <param name="inventoryTransferDeliveryDetailId">The value of the column "inventory_transfer_delivery_detail_id" which will be updated.</param>
        void Update(dynamic inventoryTransferDeliveryDetail, long inventoryTransferDeliveryDetailId);

        /// <summary>
        /// Deletes InventoryTransferDeliveryDetail from  IInventoryTransferDeliveryDetailRepository against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferDeliveryDetailId">The value of the column "inventory_transfer_delivery_detail_id" which will be deleted.</param>
        void Delete(long inventoryTransferDeliveryDetailId);

        /// <summary>
        /// Produces a paginated result of 10 InventoryTransferDeliveryDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of InventoryTransferDeliveryDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDeliveryDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 InventoryTransferDeliveryDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of InventoryTransferDeliveryDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDeliveryDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IInventoryTransferDeliveryDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of InventoryTransferDeliveryDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IInventoryTransferDeliveryDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of InventoryTransferDeliveryDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDeliveryDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IInventoryTransferDeliveryDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of InventoryTransferDeliveryDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IInventoryTransferDeliveryDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of InventoryTransferDeliveryDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDeliveryDetail> GetFiltered(long pageNumber, string filterName);



    }
}