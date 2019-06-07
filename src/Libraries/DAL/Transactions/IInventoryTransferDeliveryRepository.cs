// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IInventoryTransferDeliveryRepository
    {
        /// <summary>
        /// Counts the number of InventoryTransferDelivery in IInventoryTransferDeliveryRepository.
        /// </summary>
        /// <returns>Returns the count of IInventoryTransferDeliveryRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of InventoryTransferDelivery. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of InventoryTransferDelivery.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetAll();

        /// <summary>
        /// Returns all instances of InventoryTransferDelivery to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of InventoryTransferDelivery.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the InventoryTransferDelivery against inventoryTransferDeliveryId. 
        /// </summary>
        /// <param name="inventoryTransferDeliveryId">The column "inventory_transfer_delivery_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of InventoryTransferDelivery.</returns>
        MixERP.Net.Entities.Transactions.InventoryTransferDelivery Get(long inventoryTransferDeliveryId);

        /// <summary>
        /// Returns multiple instances of the InventoryTransferDelivery against inventoryTransferDeliveryIds. 
        /// </summary>
        /// <param name="inventoryTransferDeliveryIds">Array of column "inventory_transfer_delivery_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of InventoryTransferDelivery.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> Get(long[] inventoryTransferDeliveryIds);

        /// <summary>
        /// Custom fields are user defined form elements for IInventoryTransferDeliveryRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for InventoryTransferDelivery.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding InventoryTransferDelivery.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for InventoryTransferDelivery.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of InventoryTransferDelivery class to IInventoryTransferDeliveryRepository.
        /// </summary>
        /// <param name="inventoryTransferDelivery">The instance of InventoryTransferDelivery class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic inventoryTransferDelivery, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of InventoryTransferDelivery class to IInventoryTransferDeliveryRepository.
        /// </summary>
        /// <param name="inventoryTransferDelivery">The instance of InventoryTransferDelivery class to insert.</param>
        object Add(dynamic inventoryTransferDelivery);

        /// <summary>
        /// Inserts or updates multiple instances of InventoryTransferDelivery class to IInventoryTransferDeliveryRepository.;
        /// </summary>
        /// <param name="inventoryTransferDeliveries">List of InventoryTransferDelivery class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> inventoryTransferDeliveries);


        /// <summary>
        /// Updates IInventoryTransferDeliveryRepository with an instance of InventoryTransferDelivery class against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferDelivery">The instance of InventoryTransferDelivery class to update.</param>
        /// <param name="inventoryTransferDeliveryId">The value of the column "inventory_transfer_delivery_id" which will be updated.</param>
        void Update(dynamic inventoryTransferDelivery, long inventoryTransferDeliveryId);

        /// <summary>
        /// Deletes InventoryTransferDelivery from  IInventoryTransferDeliveryRepository against the primary key value.
        /// </summary>
        /// <param name="inventoryTransferDeliveryId">The value of the column "inventory_transfer_delivery_id" which will be deleted.</param>
        void Delete(long inventoryTransferDeliveryId);

        /// <summary>
        /// Produces a paginated result of 10 InventoryTransferDelivery classes.
        /// </summary>
        /// <returns>Returns the first page of collection of InventoryTransferDelivery class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 InventoryTransferDelivery classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of InventoryTransferDelivery class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IInventoryTransferDeliveryRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of InventoryTransferDelivery class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IInventoryTransferDeliveryRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of InventoryTransferDelivery class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IInventoryTransferDeliveryRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of InventoryTransferDelivery class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IInventoryTransferDeliveryRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of InventoryTransferDelivery class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferDelivery> GetFiltered(long pageNumber, string filterName);



    }
}