// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemCostPriceRepository
    {
        /// <summary>
        /// Counts the number of ItemCostPrice in IItemCostPriceRepository.
        /// </summary>
        /// <returns>Returns the count of IItemCostPriceRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ItemCostPrice. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemCostPrice.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> GetAll();

        /// <summary>
        /// Returns all instances of ItemCostPrice to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemCostPrice.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ItemCostPrice against itemCostPriceId. 
        /// </summary>
        /// <param name="itemCostPriceId">The column "item_cost_price_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemCostPrice.</returns>
        MixERP.Net.Entities.Core.ItemCostPrice Get(long itemCostPriceId);

        /// <summary>
        /// Gets the first record of ItemCostPrice.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemCostPrice.</returns>
        MixERP.Net.Entities.Core.ItemCostPrice GetFirst();

        /// <summary>
        /// Gets the previous record of ItemCostPrice sorted by itemCostPriceId. 
        /// </summary>
        /// <param name="itemCostPriceId">The column "item_cost_price_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemCostPrice.</returns>
        MixERP.Net.Entities.Core.ItemCostPrice GetPrevious(long itemCostPriceId);

        /// <summary>
        /// Gets the next record of ItemCostPrice sorted by itemCostPriceId. 
        /// </summary>
        /// <param name="itemCostPriceId">The column "item_cost_price_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemCostPrice.</returns>
        MixERP.Net.Entities.Core.ItemCostPrice GetNext(long itemCostPriceId);

        /// <summary>
        /// Gets the last record of ItemCostPrice.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemCostPrice.</returns>
        MixERP.Net.Entities.Core.ItemCostPrice GetLast();

        /// <summary>
        /// Returns multiple instances of the ItemCostPrice against itemCostPriceIds. 
        /// </summary>
        /// <param name="itemCostPriceIds">Array of column "item_cost_price_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ItemCostPrice.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> Get(long[] itemCostPriceIds);

        /// <summary>
        /// Custom fields are user defined form elements for IItemCostPriceRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ItemCostPrice.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ItemCostPrice.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ItemCostPrice.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ItemCostPrice class to IItemCostPriceRepository.
        /// </summary>
        /// <param name="itemCostPrice">The instance of ItemCostPrice class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic itemCostPrice, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ItemCostPrice class to IItemCostPriceRepository.
        /// </summary>
        /// <param name="itemCostPrice">The instance of ItemCostPrice class to insert.</param>
        object Add(dynamic itemCostPrice);

        /// <summary>
        /// Inserts or updates multiple instances of ItemCostPrice class to IItemCostPriceRepository.;
        /// </summary>
        /// <param name="itemCostPrices">List of ItemCostPrice class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> itemCostPrices);


        /// <summary>
        /// Updates IItemCostPriceRepository with an instance of ItemCostPrice class against the primary key value.
        /// </summary>
        /// <param name="itemCostPrice">The instance of ItemCostPrice class to update.</param>
        /// <param name="itemCostPriceId">The value of the column "item_cost_price_id" which will be updated.</param>
        void Update(dynamic itemCostPrice, long itemCostPriceId);

        /// <summary>
        /// Deletes ItemCostPrice from  IItemCostPriceRepository against the primary key value.
        /// </summary>
        /// <param name="itemCostPriceId">The value of the column "item_cost_price_id" which will be deleted.</param>
        void Delete(long itemCostPriceId);

        /// <summary>
        /// Produces a paginated result of 10 ItemCostPrice classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ItemCostPrice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ItemCostPrice classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ItemCostPrice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemCostPriceRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ItemCostPrice class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IItemCostPriceRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ItemCostPrice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemCostPriceRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ItemCostPrice class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IItemCostPriceRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ItemCostPrice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemCostPrice> GetFiltered(long pageNumber, string filterName);



    }
}