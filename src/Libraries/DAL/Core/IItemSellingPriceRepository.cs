// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IItemSellingPriceRepository
    {
        /// <summary>
        /// Counts the number of ItemSellingPrice in IItemSellingPriceRepository.
        /// </summary>
        /// <returns>Returns the count of IItemSellingPriceRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of ItemSellingPrice. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemSellingPrice.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetAll();

        /// <summary>
        /// Returns all instances of ItemSellingPrice to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of ItemSellingPrice.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the ItemSellingPrice against itemSellingPriceId. 
        /// </summary>
        /// <param name="itemSellingPriceId">The column "item_selling_price_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemSellingPrice.</returns>
        MixERP.Net.Entities.Core.ItemSellingPrice Get(long itemSellingPriceId);

        /// <summary>
        /// Gets the first record of ItemSellingPrice.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemSellingPrice.</returns>
        MixERP.Net.Entities.Core.ItemSellingPrice GetFirst();

        /// <summary>
        /// Gets the previous record of ItemSellingPrice sorted by itemSellingPriceId. 
        /// </summary>
        /// <param name="itemSellingPriceId">The column "item_selling_price_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemSellingPrice.</returns>
        MixERP.Net.Entities.Core.ItemSellingPrice GetPrevious(long itemSellingPriceId);

        /// <summary>
        /// Gets the next record of ItemSellingPrice sorted by itemSellingPriceId. 
        /// </summary>
        /// <param name="itemSellingPriceId">The column "item_selling_price_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of ItemSellingPrice.</returns>
        MixERP.Net.Entities.Core.ItemSellingPrice GetNext(long itemSellingPriceId);

        /// <summary>
        /// Gets the last record of ItemSellingPrice.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of ItemSellingPrice.</returns>
        MixERP.Net.Entities.Core.ItemSellingPrice GetLast();

        /// <summary>
        /// Returns multiple instances of the ItemSellingPrice against itemSellingPriceIds. 
        /// </summary>
        /// <param name="itemSellingPriceIds">Array of column "item_selling_price_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of ItemSellingPrice.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> Get(long[] itemSellingPriceIds);

        /// <summary>
        /// Custom fields are user defined form elements for IItemSellingPriceRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for ItemSellingPrice.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ItemSellingPrice.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ItemSellingPrice.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of ItemSellingPrice class to IItemSellingPriceRepository.
        /// </summary>
        /// <param name="itemSellingPrice">The instance of ItemSellingPrice class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic itemSellingPrice, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of ItemSellingPrice class to IItemSellingPriceRepository.
        /// </summary>
        /// <param name="itemSellingPrice">The instance of ItemSellingPrice class to insert.</param>
        object Add(dynamic itemSellingPrice);

        /// <summary>
        /// Inserts or updates multiple instances of ItemSellingPrice class to IItemSellingPriceRepository.;
        /// </summary>
        /// <param name="itemSellingPrices">List of ItemSellingPrice class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> itemSellingPrices);


        /// <summary>
        /// Updates IItemSellingPriceRepository with an instance of ItemSellingPrice class against the primary key value.
        /// </summary>
        /// <param name="itemSellingPrice">The instance of ItemSellingPrice class to update.</param>
        /// <param name="itemSellingPriceId">The value of the column "item_selling_price_id" which will be updated.</param>
        void Update(dynamic itemSellingPrice, long itemSellingPriceId);

        /// <summary>
        /// Deletes ItemSellingPrice from  IItemSellingPriceRepository against the primary key value.
        /// </summary>
        /// <param name="itemSellingPriceId">The value of the column "item_selling_price_id" which will be deleted.</param>
        void Delete(long itemSellingPriceId);

        /// <summary>
        /// Produces a paginated result of 10 ItemSellingPrice classes.
        /// </summary>
        /// <returns>Returns the first page of collection of ItemSellingPrice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 ItemSellingPrice classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of ItemSellingPrice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IItemSellingPriceRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of ItemSellingPrice class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IItemSellingPriceRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of ItemSellingPrice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IItemSellingPriceRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of ItemSellingPrice class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IItemSellingPriceRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of ItemSellingPrice class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.ItemSellingPrice> GetFiltered(long pageNumber, string filterName);



    }
}