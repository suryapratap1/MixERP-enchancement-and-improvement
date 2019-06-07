// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemRepository
    {
        /// <summary>
        /// Counts the number of Item in IItemRepository.
        /// </summary>
        /// <returns>Returns the count of IItemRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Item. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Item.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Item> GetAll();

        /// <summary>
        /// Returns all instances of Item to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Item.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Item against itemId. 
        /// </summary>
        /// <param name="itemId">The column "item_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Item.</returns>
        MixERP.Net.Entities.Core.Item Get(int itemId);

        /// <summary>
        /// Gets the first record of Item.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Item.</returns>
        MixERP.Net.Entities.Core.Item GetFirst();

        /// <summary>
        /// Gets the previous record of Item sorted by itemId. 
        /// </summary>
        /// <param name="itemId">The column "item_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Item.</returns>
        MixERP.Net.Entities.Core.Item GetPrevious(int itemId);

        /// <summary>
        /// Gets the next record of Item sorted by itemId. 
        /// </summary>
        /// <param name="itemId">The column "item_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Item.</returns>
        MixERP.Net.Entities.Core.Item GetNext(int itemId);

        /// <summary>
        /// Gets the last record of Item.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Item.</returns>
        MixERP.Net.Entities.Core.Item GetLast();

        /// <summary>
        /// Returns multiple instances of the Item against itemIds. 
        /// </summary>
        /// <param name="itemIds">Array of column "item_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Item.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Item> Get(int[] itemIds);

        /// <summary>
        /// Custom fields are user defined form elements for IItemRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Item.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Item.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Item.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Item class to IItemRepository.
        /// </summary>
        /// <param name="item">The instance of Item class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic item, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Item class to IItemRepository.
        /// </summary>
        /// <param name="item">The instance of Item class to insert.</param>
        object Add(dynamic item);

        /// <summary>
        /// Inserts or updates multiple instances of Item class to IItemRepository.;
        /// </summary>
        /// <param name="items">List of Item class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> items);


        /// <summary>
        /// Updates IItemRepository with an instance of Item class against the primary key value.
        /// </summary>
        /// <param name="item">The instance of Item class to update.</param>
        /// <param name="itemId">The value of the column "item_id" which will be updated.</param>
        void Update(dynamic item, int itemId);

        /// <summary>
        /// Deletes Item from  IItemRepository against the primary key value.
        /// </summary>
        /// <param name="itemId">The value of the column "item_id" which will be deleted.</param>
        void Delete(int itemId);

        /// <summary>
        /// Produces a paginated result of 10 Item classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Item class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Item> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Item classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Item class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Item> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Item class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IItemRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Item class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Item> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Item class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IItemRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Item class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.Item> GetFiltered(long pageNumber, string filterName);



    }
}