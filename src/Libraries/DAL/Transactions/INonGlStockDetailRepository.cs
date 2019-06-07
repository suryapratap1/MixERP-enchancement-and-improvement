// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface INonGlStockDetailRepository
    {
        /// <summary>
        /// Counts the number of NonGlStockDetail in INonGlStockDetailRepository.
        /// </summary>
        /// <returns>Returns the count of INonGlStockDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of NonGlStockDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of NonGlStockDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockDetail> GetAll();

        /// <summary>
        /// Returns all instances of NonGlStockDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of NonGlStockDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the NonGlStockDetail against nonGlStockDetailId. 
        /// </summary>
        /// <param name="nonGlStockDetailId">The column "non_gl_stock_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of NonGlStockDetail.</returns>
        MixERP.Net.Entities.Transactions.NonGlStockDetail Get(long nonGlStockDetailId);

        /// <summary>
        /// Returns multiple instances of the NonGlStockDetail against nonGlStockDetailIds. 
        /// </summary>
        /// <param name="nonGlStockDetailIds">Array of column "non_gl_stock_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of NonGlStockDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockDetail> Get(long[] nonGlStockDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for INonGlStockDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for NonGlStockDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding NonGlStockDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for NonGlStockDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of NonGlStockDetail class to INonGlStockDetailRepository.
        /// </summary>
        /// <param name="nonGlStockDetail">The instance of NonGlStockDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic nonGlStockDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of NonGlStockDetail class to INonGlStockDetailRepository.
        /// </summary>
        /// <param name="nonGlStockDetail">The instance of NonGlStockDetail class to insert.</param>
        object Add(dynamic nonGlStockDetail);

        /// <summary>
        /// Inserts or updates multiple instances of NonGlStockDetail class to INonGlStockDetailRepository.;
        /// </summary>
        /// <param name="nonGlStockDetails">List of NonGlStockDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> nonGlStockDetails);


        /// <summary>
        /// Updates INonGlStockDetailRepository with an instance of NonGlStockDetail class against the primary key value.
        /// </summary>
        /// <param name="nonGlStockDetail">The instance of NonGlStockDetail class to update.</param>
        /// <param name="nonGlStockDetailId">The value of the column "non_gl_stock_detail_id" which will be updated.</param>
        void Update(dynamic nonGlStockDetail, long nonGlStockDetailId);

        /// <summary>
        /// Deletes NonGlStockDetail from  INonGlStockDetailRepository against the primary key value.
        /// </summary>
        /// <param name="nonGlStockDetailId">The value of the column "non_gl_stock_detail_id" which will be deleted.</param>
        void Delete(long nonGlStockDetailId);

        /// <summary>
        /// Produces a paginated result of 10 NonGlStockDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of NonGlStockDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 NonGlStockDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of NonGlStockDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on INonGlStockDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of NonGlStockDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against INonGlStockDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of NonGlStockDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on INonGlStockDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of NonGlStockDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of INonGlStockDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of NonGlStockDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.NonGlStockDetail> GetFiltered(long pageNumber, string filterName);



    }
}