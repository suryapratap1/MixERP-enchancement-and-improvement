// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Office.Data
{
    public interface IStoreRepository
    {
        /// <summary>
        /// Counts the number of Store in IStoreRepository.
        /// </summary>
        /// <returns>Returns the count of IStoreRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of Store. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Store.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Store> GetAll();

        /// <summary>
        /// Returns all instances of Store to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of Store.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the Store against storeId. 
        /// </summary>
        /// <param name="storeId">The column "store_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of Store.</returns>
        MixERP.Net.Entities.Office.Store Get(int storeId);

        /// <summary>
        /// Gets the first record of Store.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Store.</returns>
        MixERP.Net.Entities.Office.Store GetFirst();

        /// <summary>
        /// Gets the previous record of Store sorted by storeId. 
        /// </summary>
        /// <param name="storeId">The column "store_id" parameter used to find the previous record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Store.</returns>
        MixERP.Net.Entities.Office.Store GetPrevious(int storeId);

        /// <summary>
        /// Gets the next record of Store sorted by storeId. 
        /// </summary>
        /// <param name="storeId">The column "store_id" parameter used to find the next record.</param>
        /// <returns>Returns a non-live, non-mapped instance of Store.</returns>
        MixERP.Net.Entities.Office.Store GetNext(int storeId);

        /// <summary>
        /// Gets the last record of Store.
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instance of Store.</returns>
        MixERP.Net.Entities.Office.Store GetLast();

        /// <summary>
        /// Returns multiple instances of the Store against storeIds. 
        /// </summary>
        /// <param name="storeIds">Array of column "store_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of Store.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Store> Get(int[] storeIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStoreRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for Store.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding Store.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for Store.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of Store class to IStoreRepository.
        /// </summary>
        /// <param name="store">The instance of Store class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic store, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of Store class to IStoreRepository.
        /// </summary>
        /// <param name="store">The instance of Store class to insert.</param>
        object Add(dynamic store);

        /// <summary>
        /// Inserts or updates multiple instances of Store class to IStoreRepository.;
        /// </summary>
        /// <param name="stores">List of Store class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> stores);


        /// <summary>
        /// Updates IStoreRepository with an instance of Store class against the primary key value.
        /// </summary>
        /// <param name="store">The instance of Store class to update.</param>
        /// <param name="storeId">The value of the column "store_id" which will be updated.</param>
        void Update(dynamic store, int storeId);

        /// <summary>
        /// Deletes Store from  IStoreRepository against the primary key value.
        /// </summary>
        /// <param name="storeId">The value of the column "store_id" which will be deleted.</param>
        void Delete(int storeId);

        /// <summary>
        /// Produces a paginated result of 10 Store classes.
        /// </summary>
        /// <returns>Returns the first page of collection of Store class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Store> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 Store classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of Store class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Store> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStoreRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of Store class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStoreRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of Store class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Store> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStoreRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of Store class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStoreRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of Store class.</returns>
        IEnumerable<MixERP.Net.Entities.Office.Store> GetFiltered(long pageNumber, string filterName);



    }
}