// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework;
using PetaPoco;

namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IStockDetailRepository
    {
        /// <summary>
        /// Counts the number of StockDetail in IStockDetailRepository.
        /// </summary>
        /// <returns>Returns the count of IStockDetailRepository.</returns>
        long Count();

        /// <summary>
        /// Returns all instances of StockDetail. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> GetAll();

        /// <summary>
        /// Returns all instances of StockDetail to export. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of StockDetail.</returns>
        IEnumerable<dynamic> Export();

        /// <summary>
        /// Returns a single instance of the StockDetail against stockDetailId. 
        /// </summary>
        /// <param name="stockDetailId">The column "stock_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped instance of StockDetail.</returns>
        MixERP.Net.Entities.Transactions.StockDetail Get(long stockDetailId);

        /// <summary>
        /// Returns multiple instances of the StockDetail against stockDetailIds. 
        /// </summary>
        /// <param name="stockDetailIds">Array of column "stock_detail_id" parameter used on where filter.</param>
        /// <returns>Returns a non-live, non-mapped collection of StockDetail.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> Get(long[] stockDetailIds);

        /// <summary>
        /// Custom fields are user defined form elements for IStockDetailRepository.
        /// </summary>
        /// <returns>Returns an enumerable custom field collection for StockDetail.</returns>
        IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId);

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding StockDetail.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for StockDetail.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Inserts the instance of StockDetail class to IStockDetailRepository.
        /// </summary>
        /// <param name="stockDetail">The instance of StockDetail class to insert or update.</param>
        /// <param name="customFields">The custom field collection.</param>
        object AddOrEdit(dynamic stockDetail, List<EntityParser.CustomField> customFields);

        /// <summary>
        /// Inserts the instance of StockDetail class to IStockDetailRepository.
        /// </summary>
        /// <param name="stockDetail">The instance of StockDetail class to insert.</param>
        object Add(dynamic stockDetail);

        /// <summary>
        /// Inserts or updates multiple instances of StockDetail class to IStockDetailRepository.;
        /// </summary>
        /// <param name="stockDetails">List of StockDetail class to import.</param>
        /// <returns>Returns list of inserted object ids.</returns>
        List<object> BulkImport(List<ExpandoObject> stockDetails);


        /// <summary>
        /// Updates IStockDetailRepository with an instance of StockDetail class against the primary key value.
        /// </summary>
        /// <param name="stockDetail">The instance of StockDetail class to update.</param>
        /// <param name="stockDetailId">The value of the column "stock_detail_id" which will be updated.</param>
        void Update(dynamic stockDetail, long stockDetailId);

        /// <summary>
        /// Deletes StockDetail from  IStockDetailRepository against the primary key value.
        /// </summary>
        /// <param name="stockDetailId">The value of the column "stock_detail_id" which will be deleted.</param>
        void Delete(long stockDetailId);

        /// <summary>
        /// Produces a paginated result of 10 StockDetail classes.
        /// </summary>
        /// <returns>Returns the first page of collection of StockDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 StockDetail classes.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of StockDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IStockDetailRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of StockDetail class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered pagination against IStockDetailRepository producing result of 10 items.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of StockDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IStockDetailRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of StockDetail class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Gets a filtered result of IStockDetailRepository producing a paginated result of 10.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of StockDetail class.</returns>
        IEnumerable<MixERP.Net.Entities.Transactions.StockDetail> GetFiltered(long pageNumber, string filterName);



    }
}